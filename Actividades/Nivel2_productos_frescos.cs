public class productos_frescos extends producto{

public string fecha_envasado;
public string pais_origen;

public productos_frescos(string nombre_producto,int numero_lote,string fecha_envasado,string pais_origen){
super(nombre_producto, numero_lote);

this.fecha_envasado = fecha_envasado;
this.pais_origen = pais_origen;
}
public string getfechaenvasado(){
    return this.fecha_envasado
}
public void setfechaenvasado(string fecha_envasado){
    this.fecha_envasado=fecha_envasado;

}
public string getpaisorign(){
    return this.pais_origen;
}
public void setpaisorign(string pais_origen){
    this.pais_origen=pais_origen;
}
public void mostrar(){
    Console.WriteLine(super.nombre_producto);
    Console.WriteLine(super.numero_lote);
    Console.WriteLine(this.fecha_envasado);
    Console.WriteLine(this.pais_origen);
}
}