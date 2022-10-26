public class productos_refrigerados extends producto{
    public string cod_supervisión;

public productos_refrigerados(string nombre_producto, string numero_lote,string cod_supervisión){
    super(nombre_producto, numero_lote);
}
public string getcodsupervision(){
    return this.cod_supervisión;
}
public void setcodsupervision(cod_supervisión){
    this.cod_supervisión=cod_supervisión;
}
public void mostrar(){
    Console.WriteLine(super.nombre_producto);
    Console.WriteLine(super.numero_lote);
    Console.WriteLine(this.cod_supervisión);
}
}
{
    
}