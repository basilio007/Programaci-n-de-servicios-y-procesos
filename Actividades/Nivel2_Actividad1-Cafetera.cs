public class Cafetera{
    public int capacidadMax=0;
    public int capacidadActual=0;

    public Cafetera(){
        this.capacidadMax=100;
        this.capacidadActual=0;
    }
}
public Cafetera(int capacidadMax){
    this.capacidadMax=100;
    this.capacidadActual=this.capacidadMax;

}
public Cafetera(int capacidadMax, int capacidadActual){
this.capacidadMax = capacidadMax;
if (capacidadActual>capacidadMax){
    this.capacidadActual=capacidadMax;

}else{
    this.capacidadActual=capacidadActual;

}
 public int getcapacidadMax(){
    return this.capacidadMax;

 }
 public void  setcapacidadMax(int capacidadMax){
    this.capacidadMax = this.capacidadMax;
 }
 public int getcapacidActtual(){
    return this.capacidActtual;

 }
 public void  setcapacidadActtual(int capacidadActual){
    this.capacidadActtual=this.capacidadActtual;
 }
 public void llenarCafetera(){
    this.capacidadActtual = this.capacidadMax;
 }
 public void servirTaza(int cantidadAsevir){
    if(cantidadAsevir>capacidadActtual){
        vaciarCafetera();
        
    }else{
        this.capacidadActtual=cantidadAsevir;
    }
public void vaciarCafetera(){
    this.capacidadActtual=0;
}
public void agregarCafe(int cantidadAsevir){
if(this.capacidadActtual+cantidadAsevir>this.capacidadMax){
    llenarCafetera();

}else{
    this.capacidadActtual==cantidadAsevir;
}
}
 }
}
{
    
}
{
    
}