package Servidor;

public class Main {

	public static HiloTerminal hilo = new HiloTerminal();
	
	public static void main(String[] args) {
		hilo.setPriority(10);
		hilo.run();
	}

}
