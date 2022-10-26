public class Cuenta_joven extends cuenta{
    public int edad;
    public Cuenta_joven(string titular,int cantidad, int edad){
        super(titula, cantidad);
    }
    public int getedad(){
        return this.edad;
    }
    public void setedad( int edad){
 this.edad=edad;
    }
    public boolean titularvalido(int edad){

        if (this.edad>18&&this.edad<25){

        return titularvalido = true; 

        }else {
            titularvalido=false;
        }
public void retirar(float cantidad){
    if (cantidad>0&&titularvalido()==true){
        super.cantidad-=cantidad
    }
    public void mostrar(){
        Console.WriteLine(super.titular);
        Console.WriteLine(super.cantidad);
        Console.WriteLine(this.edad);
    }
}
    }
   

}