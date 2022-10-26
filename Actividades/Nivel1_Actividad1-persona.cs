public class persona{
   private String nombre;
   private int edad;
   private String DNI;
}
public persona(String nombre,int edad,String DNI) {
	this.nombre=nombre;
	this.edad=edad;
	this.DNI=DNI;	
}
public String getnombre() {
	return this.nombre;
}
public void setnombre(String nombre) {
	this.nombre=nombre;
}
public int getedad() {
	return this.edad;
}
public void setedad(int edad) {
	this.edad=edad;
}
public String getDNI() {
	return this.DNI;
}
public void setDNI(String DNI) {
	this.DNI=DNI;
}
public String mostrar() {
	if(this.edad>18){
         Console.WriteLine("la persona es mayor de edad");
       

    }
}
