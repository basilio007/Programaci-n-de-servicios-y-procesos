public class producto{
    public string nombre_producto;
public int numero_lote;

public producto(string nombre_producto, int numero_lote){
this.nombre_producto=nombre_producto;
this.numero_lote = numero_lote;
}
public string getNombreProducto(){
return this.nombre_producto;
}
public void setNombreProducto(string nombre_producto){
this.nombre_producto=nombre_producto;

}
public string getNumeroLote(){
return this.numero_lote;
}
public void setNumeroLote(int numero_lote){
this.int numero_lote=int numero_lote;

}