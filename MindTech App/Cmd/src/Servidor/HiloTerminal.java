package Servidor;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Random;
import java.util.Scanner;

public class HiloTerminal extends Thread{
	String ruta = "C:/";
	int carpetaActual = 1;
	Scanner teclado;
	Connection conexion;
	private boolean ejecutar = true;
	
	@Override
	public void run() {
		teclado = new Scanner(System.in);
        try {
        	//Cargar el driver
			Class.forName("com.mysql.cj.jdbc.Driver");
			conexion = DriverManager.getConnection("jdbc:mysql://localhost/arg", "root", "marisma");
		} catch (ClassNotFoundException | SQLException e) {
			e.printStackTrace();
		}
		
		accederServidor();
		
		while(ejecutar) {
			String comando = leerComando();
			ejecutarComando(comando);
		}
	}
	
	public void accederServidor() {
		Random rng = new Random();
		System.out.print("Cargando carpetas");
		for(int i = 0; i < rng.nextInt(15) + 5; i++) {
			try {
				sleep(rng.nextInt(250) + 100);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			System.out.print(".");
		}
		System.out.println("\nSe ha cargado todo el contenido.\n");
		//System.out.println("Utiliza el comando help si necesitas ayuda.\n");
	}
	
	// Recalcula la ruta
	public void actualizarRuta() {
		ruta = calcularRuta(carpetaActual);
		if(carpetaActual == 1)
			ruta += "/";
	}
	public String calcularRuta(int id) {
		try {
			if(id == 0) {
				return "";
			}
			
			String sql;
			Statement sentencia;
			ResultSet rdo;

			sql = "SELECT padre, nombre FROM carpetas WHERE id = "+ id;
	        sentencia = conexion.createStatement();
	        rdo = sentencia.executeQuery(sql);
	        
	        if(rdo.next()) {
	        	if(id == 1)
		        	return rdo.getString(2);
		        else
		        	return calcularRuta(rdo.getInt(1)) + "/" + rdo.getString(2);
	        }
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return "";
	}
	
	// Obtiene el comando por teclado
	public String leerComando() {
		if(ruta.equals("C:"))
			ruta += "/";
		
		System.out.print(ruta + "> ");
		return teclado.nextLine();
	}
	
	// Responde al comando introducido
	public void ejecutarComando(String comando) {
		try {
			switch(comando.split(" ")[0].toLowerCase()) {
			case "help":
				System.out.println("\n-- Lista de comandos --\n"
								 + "\thelp \t-\t-\t-\t-\t- Ayuda\n"
								 + "\tdir \t-\t-\t-\t-\t- Listado del contenido del directorio actual\n"
								 + "\tcd [directorio] [contraseña] \t-\t- Entrar a un directorio\n"
								 + "\tmkdir [nombre] \t-\t-\t-\t- Crear una carpeta\n"
								 + "\tmkfile [nombre] \t-\t-\t- Crear un fichero\n"
								 + "\ttype [fichero] \t-\t-\t-\t- Leer fichero\n"
								 + "\texit \t-\t-\t-\t-\t- Salir de la Cmd\n"
								 + "-----------------------");
				break;
			case "dir":
				dir();
				break;
				
			case "cd":
				// Separamos la ruta por las /
				String rutaC = comando.split(" ")[1];
				String contra = (comando.split(" ").length > 2)? comando.split(" ")[2]:"";
				int idPadre = carpetaActual;
				int temp = cd(idPadre, rutaC, contra);
				
				// Mensajes de error
				if(temp == -1) // Ruta mal
					System.err.println("El sistema no puede encontrar la ruta especificada.");
				else if(temp == -2) // No contra
					System.err.println("[C] Ésta carpeta está protegida por contraseña.");
				else if(temp == -3) // Contra mal
					System.err.println("Contraseña incorrecta.");
				else if(temp == -4) // GM-xxxx incorrecto
					System.err.println("No se puede acceder a esta carpeta.");
				else if(temp > 0)
					carpetaActual = temp;
				actualizarRuta();
				
				break;
			case "mkdir":
				mkdir(comando.split(" ")[1]);
				break;
			case "mkfile":
				mkfile(comando.split(" ")[1]);
				break;
			case "type":
				type(comando.split(" ")[1]);
				break;
			case "exit":
				System.out.println("\nSaliendo de la cmd.");
				try {
					sleep(1000);
				} catch (InterruptedException e) {}
				this.ejecutar = false;
				break;
				default:
					System.out.println("\"" + comando.split(" ")[0] + "\" no se ha reconocido como comando. Utiliza el comando help para obtener ayuda.");
			}
		}catch(ArrayIndexOutOfBoundsException e) {
			System.err.println("La sintaxis del comando no es correcta.");
		}
		System.out.println();
	}
	
	// Se mueve a la carpeta dada, no permite rutas
	public int cd(int padre, String nombre, String contra) {
		try {
			
			// Si está en sujetosGM
			if(carpetaActual == 28) {
				if(!nombre.toUpperCase().equals("GM-9625") && !nombre.toUpperCase().equals("GM-2735") && nombre.toUpperCase().startsWith("GM-")) {
					return -4;
				}
			}
			
			String sql;
			Statement sentencia;
			ResultSet rdo;
			
			// Si es .. devolvemos el idPadre
			if(nombre.equals("..") && padre != 1) {
				sql = "SELECT padre, contrasena, desbloqueada FROM carpetas WHERE id = "+ padre +"";
			}else{
				// Devolvemos el id de esa carpeta
				sql = "SELECT id, contrasena, desbloqueada FROM carpetas WHERE nombre like '"+ nombre +"' AND padre = " + padre;
			}
	        sentencia = conexion.createStatement();
	        rdo = sentencia.executeQuery(sql);
	        
	        if(rdo.next()){
	        	
	        	if(rdo.getInt(3) == 0 && !rdo.getString(2).isEmpty()) { // Si no está desbloqueada comprobamos la contraseña
	        		
		        	// Si ha acertado la contraseña
		        	if(rdo.getString(2).equals(contra)) {
		        		
		        		// Desbloqueamos la carpeta
		        		sql = "UPDATE carpetas SET desbloqueada = 1 WHERE nombre like '"+nombre+"' AND padre = "+ padre;
		        		Statement sentencia2 = conexion.createStatement();
		        		sentencia2.executeUpdate(sql);
		        		
		        		// Devolvemos el id
		        		return rdo.getInt(1);
		        	}else {
		        		// Si no escribe contraseña, se le avisa de la mecánica
		    			if(contra.equals("")) 
		    				return -2;
		    			else // Se ha equivocado en la contraseña
		    				return -3;
		        	}
	        	}else { // Está desbloqueada
	        		return rdo.getInt(1);
	        	}
	        }
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return -1;
	}
	
	// Muestra una lista del contenido de la carpeta actual
	public void dir() {
		try {
			System.out.println("\nDirectorio de " + ruta + "\n");
			
			// Si es la carpeta de sujetos mostramos un monton
			if(carpetaActual == 28) {
	        	System.out.println("<DIR>\t\t..");
				for(int i = 1; i <= 3; i++) {
		        	System.out.println("<DIR> \t\tGM-000"+i);
				}
				System.out.println("\t\t.");
				System.out.println("\t\t.");
				System.out.println("\t\t.");
				System.out.println("<DIR> \t\tGM-9832");
				return;
			}
			
			// Mostramos el contenido normalmente
			String sql, nombre = ruta.split("/")[0];
			Statement sentencia;
			ResultSet rdo;
			
			// Mostramos las Carpetas
			sql = "SELECT nombre, contrasena FROM carpetas WHERE padre = "+ carpetaActual;
	        sentencia = conexion.createStatement();
	        rdo = sentencia.executeQuery(sql);
	        
	        // Mostramos la lista
	        if(carpetaActual != 1)
	        	System.out.println("<DIR>\t\t..");
	        while(rdo.next()) {
	        	System.out.println("<DIR>"+ ((rdo.getString(2).isEmpty())? "\t":" [C]") +"\t" + rdo.getString(1));
	        }
	        
	        // Mostramos los archivos
			sql = "SELECT nombre FROM archivos WHERE padre = "+ carpetaActual;
	        sentencia = conexion.createStatement();
	        rdo = sentencia.executeQuery(sql);
	        
	        // Mostramos la lista
	        while(rdo.next()) {
	        	System.out.println("<FILE>\t\t" + rdo.getString(1));
	        }
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	// Crea una carpeta
	public void mkdir(String nombre) {
		try {
			if(!nombre.contains(".") && !nombre.contains("/") && !nombre.equals("")) {
				String sql;
				Statement sentencia = conexion.createStatement();
				
				// Comprobamos que no exista ya
				sql = "SELECT * FROM carpetas WHERE nombre like '"+nombre+"' AND padre = " + carpetaActual;
				ResultSet rdo = sentencia.executeQuery(sql);
				if(rdo.next()){
					System.err.println("Ya existe el directorio " + nombre + ".");
				}else {
					// Si no existe lo creamos
					sql = "INSERT INTO carpetas (nombre, padre) VALUES ('"+nombre+"', "+carpetaActual+")";
					sentencia.executeUpdate(sql);
					System.out.println("Se ha creado la carpeta "+nombre+".");
				}
			}
			else {
				System.err.println("El nombre del directorio no es correcto.");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	// Crea un fichero
	public void mkfile(String nombre) {
		try {
			if(nombre.contains(".") && !nombre.contains("/") && !nombre.equals("")) {
				String sql;
				Statement sentencia = conexion.createStatement();
				
				// Comprobamos que no exista ya
				sql = "SELECT * FROM archivos WHERE nombre like '"+nombre+"' AND padre = " + carpetaActual;
				ResultSet rdo = sentencia.executeQuery(sql);
				if(rdo.next()){
					System.err.println("Ya existe el archivo " + nombre + ".");
				}else {

					// El jugador introduce el contenido del fichero
					System.out.println("Escribe el contenido: (Escribe 'END' para terminar)");
					String linea = "", contenido = "";
					while(!linea.equals("END")) {
						linea = teclado.nextLine();
						if(!linea.equals("END"))
							contenido += linea + "\n";
					}
					
					sql = "INSERT INTO archivos (nombre, padre, contenido) VALUES ('"+nombre+"', "+carpetaActual+", '"+contenido+"')";
					sentencia.executeUpdate(sql);
					System.out.println("Se ha creado el fichero "+nombre+".");
				}
			}else {
				System.err.println("El nombre del fichero no es correcto.");
				System.out.println("Comprueba que le has añadido extensión de archivo.");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	// Lee el contenido de un fichero
	public void type(String nombre) {
		try {
			String sql = "SELECT contenido FROM archivos WHERE nombre LIKE '"+nombre+"' AND padre = "+carpetaActual;
			Statement sentencia = conexion.createStatement();
			ResultSet rdo = sentencia.executeQuery(sql);
			if(rdo.next()) 
				System.out.println("\n"+ rdo.getString(1));
			else 
				System.err.println("El sistema no puede encontrar el archivo especificado.");
		}catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	
}

/*
 * // Función recursiva que recorre las carpetas hasta llegar al sitio
	public int cdR(int padre, String ruta) {
		try {
			String sql, nombre = ruta.split("/")[0];
			Statement sentencia;
			ResultSet rdo;
			
			// Solo queda el nombre del archivo
			if(!ruta.contains("/")) {
				// Si es .. devolvemos el idPadre
				if(nombre.equals("..") && padre != 1) {
					sql = "SELECT padre FROM carpetas WHERE id = "+ padre +"";
				}else{
					// Devolvemos el id de esa carpeta
					sql = "SELECT id FROM carpetas WHERE nombre = '"+ nombre +"' AND padre = " + padre;
				}
		        sentencia = conexion.createStatement();
		        rdo = sentencia.executeQuery(sql);
		        
		        if(rdo.next()){
		            return rdo.getInt(1);
		        }else {
		        	return -1;
		        }
			// Queda más que solo una carpeta
			}else {
				// Si es .. devolvemos el idPadre
				if(nombre.equals("..") && padre != 1) 
					sql = "SELECT padre FROM carpetas WHERE id = "+ padre +"";
				else 
					sql = "SELECT id FROM carpetas WHERE nombre = '"+ nombre +"' AND padre = " + padre;
				
				// Vemos si existe la primera carpeta
		        sentencia = conexion.createStatement();
		        rdo = sentencia.executeQuery(sql);
		        
		        if(rdo.next())// Existe
		        	return cdR(rdo.getInt(1), ruta.substring(ruta.indexOf("/")+1));
		        else 
		        	return -1;
			}
	        
		} catch (SQLException e) {
			e.printStackTrace();
			return -1;
		}
	}
 * */
