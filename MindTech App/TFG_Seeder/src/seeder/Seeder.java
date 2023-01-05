package seeder;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Random;

public class Seeder {

	static ArrayList<String> nombres = new ArrayList<String>();
	static ArrayList<String> apellidos = new ArrayList<String>();
	public static Random rng = new Random();
	public static final int NUM_EMPLE = rng.nextInt(1000)+1000; // 1000 - 2000 empleados
	static long inicio;

	public static void main(String[] args) {
		inicio = System.currentTimeMillis();
		
		if (leer()) {
			System.out.println("Borrando contenido antiguo de la BD...");
			borrarEmpleados();
			// Introducimos en la base de datos
			System.out.println("\nIntroduciendo "+ NUM_EMPLE +" empleados aleatorios a la base de datos...");
			introducirDatosAleatorios();
			System.out.println("\nIntroduciendo personajes principales a la base de datos...");
			introducirDatosPredefinidos();
			System.out.println("\nReseteando el progreso...");
			resetearProgreso();
		}else {
			System.err.println("Ha ocurrido un error al leer los nombres/apellidos.");
		}
		System.out.println("\nLa operación ha durado " + (System.currentTimeMillis() - inicio) / 1000d + " s.");
	}

	public static boolean leer() {
		File fichero;
		BufferedReader buff;
		String linea;
		try {

			// Nombres masculinos
			System.out.println("Leyendo nombres masculinos...");
			fichero = new File("src/seeder/NombresM.txt");
			buff = new BufferedReader(new FileReader(fichero));

			linea = "";
			while ((linea = buff.readLine()) != null) {
				nombres.add(linea);
			}
			System.out.println("Nombres masculinos leidos: " + nombres.size() + "\n");
			int masc = nombres.size();

			// Nombres femeninos
			System.out.println("Leyendo nombres femeninos...");
			fichero = new File("src/seeder/NombresF.txt");
			buff = new BufferedReader(new FileReader(fichero));

			linea = "";
			while ((linea = buff.readLine()) != null) {
				nombres.add(linea);
			}
			System.out.println("Nombres femeninos leidos: " + (nombres.size() - masc) + "\n");
			System.out.println("Nombres totales leidos: " + nombres.size() + "\n");

			// Apellidos
			System.out.println("Leyendo apellidos...");
			fichero = new File("src/seeder/Apellidos.txt");
			buff = new BufferedReader(new FileReader(fichero));

			linea = "";
			while ((linea = buff.readLine()) != null) {
				apellidos.add(linea);
			}
			System.out.println("Apellidos leidos: " + apellidos.size() + "\n");
			buff.close();

		} catch (IOException e) {
			e.printStackTrace();
			return false;
		}
		return true;
	}

	// Introduce los personajes principales y demás pistas que se accederán con el buscador
	public static void introducirDatosPredefinidos() {
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");// Cargar el driver
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/arg", "root", "marisma");
			String sql, codigo, nombre, apellido, dni, equipo, fechaNac, fechaCont, secreto;
			Statement sentencia = conexion.createStatement();
			
			// 1. Folleto
			codigo = "███████";
			nombre = "███████";
			apellido = "███████████";
			dni = "█████████";
			fechaNac = "██ / ██ / ████";
			fechaCont = "██ / ██ / ████";
			equipo = "███████████";
			secreto = "folleto";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ dni + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo + "')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 2. Informe IA
			codigo = "MT-4598";
			nombre = "ANA CAROLINA";
			apellido = "AMADOR TABOADA";
			dni = generarDNI();
			fechaNac = generarFechaNac();
			fechaCont = generarFechaCont(fechaNac);
			equipo = "Producción";
			secreto = "buscar:cosmo armonia";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ dni + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 3. Presentación de Elia
			codigo = "MT-1375";
			nombre = "SONIA";
			apellido = "GREENE RIPOLL";
			dni = generarDNI();
			fechaNac = generarFechaNac();
			fechaCont = generarFechaCont(fechaNac);
			equipo = "marismaistración";
			secreto = "presentacion_elia";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ dni + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);

			// 4. Desbloquear CMD
			codigo = "GM-7653";
			nombre = "DAVID";
			apellido = "MOTA DOMINGUEZ";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "desbl_cmd";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 5, 6 y 7 son ficheros
			
			// 8. Mente conjunta simple
			codigo = "GM-9625";
			nombre = "ELIA";
			apellido = "BLASCO DEL VALLE";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "mente_conjunta";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ "Artefacto', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 9. Informe de la expedición
			codigo = "CIN-████";
			nombre = "MIGUEL";
			apellido = "MAESTRE AYUSO";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "████████";
			secreto = "buscar:Artefacto";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 10. Exploración
			codigo = "GM-4556";
			nombre = "JOSEPH";
			apellido = "VASQUEZ ANGULO";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "buscar:Dimensional";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 11 La Gran Mente
			codigo = "GM-2735";
			nombre = "SUSANA";
			apellido = "CARPIO GALVAN";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "la_gran_mente";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 12. Img Gran Mente
			codigo = "GM-1251";
			nombre = "AURORA";
			apellido = "FERRE CABELLO";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "buscar:TESTIGO";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
			
			// 13. El último paso y FIN
			codigo = "GM-8735";
			nombre = "ROBERT";
			apellido = "RIAL ALCALDE";
			fechaNac = generarFechaNac();
			fechaCont = "██ / ██ / ████";
			equipo = "Proyecto GM";
			secreto = "buscar:Despertar";
			sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, secreto, fechaNac, fechaCont, equipo) VALUES ('" + codigo + "', '" + nombre + "', '" + apellido + "', '"
					+ generarDNI() + "', '"+ secreto + "', '"+ fechaNac + "', '" + fechaCont + "', '" + equipo +"')";
//				System.out.println(sql);
			System.out.println(nombre + " " + apellido /* + " (DNI " + dni + ")" */);
			sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);

			sentencia.close();
			conexion.close();
		} catch (SQLException | ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	public static void introducirDatosAleatorios() {
		try {
			String sql, codigo, nombre, apellido, dni, equipo, fechaNac, fechaCont;
			String[] equipos = {"Administración", "RRHH", "Formación", "Producción"};

			Class.forName("com.mysql.cj.jdbc.Driver");// Cargar el driver
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/arg", "root", "marisma");
			Statement sentencia = conexion.createStatement();

			for (int i = 1; i <= NUM_EMPLE; i++) {
				
				// Generamos los datos
				nombre = nombres.get(rng.nextInt(nombres.size()));
				apellido = apellidos.get(rng.nextInt(apellidos.size())) + " "
						+ apellidos.get(rng.nextInt(apellidos.size()));
				dni = generarDNI();
				codigo = generarCodigo();
				fechaNac = generarFechaNac();
				fechaCont = generarFechaCont(fechaNac);
				equipo = equipos[rng.nextInt(equipos.length)];
				
				sql = "INSERT INTO empleados (codigo, nombre, apellidos, dni, fechaNac, fechaCont, equipo) "
						+ "VALUES ('" + 
							codigo 		+ "', '" + 
							nombre 		+ "', '" + 
							apellido 	+ "', '" + 
							dni 		+ "', '" + 
							fechaNac 	+ "', '" + 
							fechaCont 	+ "', '" + 
							equipo 	+ 
							"')";
//				System.out.println(sql);
				System.out.println(i + ": " + nombre + " " + apellido /* + " \n\t\t\t\t(DNI " + dni + ", "+ codigo +")" */ /* + " \n\t\t\t\t(N-" + fechaNac + " C-"+ fechaCont +")" */);
				sentencia = conexion.createStatement();
				sentencia.executeUpdate(sql);
			}

			sentencia.close();
			conexion.close();
		} catch (SQLException | ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	public static void borrarEmpleados() {
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");// Cargar el driver
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/arg", "root", "marisma");
			String sql = "DELETE FROM EMPLEADOS";
			Statement sentencia = conexion.createStatement();
			sentencia.executeUpdate(sql);
		} catch (SQLException | ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	public static String generarDNI() {
		String dni = "";
		for(int i = 0; i < 8; i++) {
			dni += rng.nextInt(10) + "";
		}
		String juegoCaracteres = "TRWAGMYFPDXBNJZSQVHLCKE";
		int modulo = Integer.parseInt(dni) % 23;
		char letra = juegoCaracteres.charAt(modulo);
		return dni + letra;
	}

	public static String generarCodigo() {
		String n = "";
		for(int i = 0; i < 4; i++) {
			n += rng.nextInt(10) + "";
		}
		return "MT-" + n;
	}
	
	public static String generarFechaNac() {
		String dia, mes, año;
		
		// Establecemos las partes separadas de la fecha
		año = (rng.nextInt(2003-1962) + 1962) + ""; // Min 1962 (60 años) Max 2003 (18 años)
		mes = (rng.nextInt(12)+ 1) + "";
		if(mes.length() == 1) mes = "0" + mes;
		dia = (rng.nextInt((mes == "02")? 28 : 30)+ 1) + "";
		if(dia.length() == 1) dia = "0" + dia;
		
		// Juntamos la fecha
		return dia + "/" + mes + "/" + año;
	}
	
	public static String generarFechaCont(String fechaNac) {
		String dia, mes, año;
		String añoNac = fechaNac.split("/")[2];
		
		// Establecemos las partes separadas de la fecha
		int min = Integer.parseInt(añoNac)+18;
		año = (rng.nextInt(2022-min) + min) + ""; // Min 1962 (60 años) Max 2003 (18 años)
		mes = (rng.nextInt(12)+ 1) + "";
		if(mes.length() == 1) mes = "0" + mes;
		dia = (rng.nextInt((mes == "02")? 28 : 30)+ 1) + "";
		if(dia.length() == 1) dia = "0" + dia;
		
		// Juntamos la fecha
		return dia + "/" + mes + "/" + año;
	}
	
	public static void resetearProgreso() {
		try {
			// Cargar el driver
			Class.forName("com.mysql.cj.jdbc.Driver");
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/arg", "root", "marisma");
			
			String sql;
			Statement sentencia = conexion.createStatement();

			// Bloqueamos todas las carpetas
			sql = "UPDATE carpetas SET desbloqueada = 0";
			sentencia.executeUpdate(sql);
			
			// Actualizamos la tabla progreso
			sql = "UPDATE progreso SET valor = 0";
			sentencia.executeUpdate(sql);
			
			// Eliminamos el archivo faltante de Elia
			sql = "DELETE FROM archivos WHERE nombre like 'GM-9625_4.txt' AND padre = 29 AND contenido like '62a77cddd8b3962a77cec423b2\n'";
			sentencia.executeUpdate(sql);
			
		} catch (ClassNotFoundException | SQLException e) {
			e.printStackTrace();
		}
	}

}
