public class Cuenta{
    private double balance_inicial;
    private tipo_de_extraccion tipo;
    
    public tipo_de_extraccion Tipo { get => tipo; set => tipo = value; }
    public double Balance_inicial { get => balance_inicial; set => balance_inicial = value; }

    public Cuenta(){

    }

    public void insercion(double monto){
        balance_inicial = balance_inicial + monto;
    }

    public virtual void extraccion(double monto, tipo_de_extraccion tipo){

    }

}

public class Cuenta_corriente_en_pesos: Cuenta{
    public override void extraccion(double monto, tipo_de_extraccion tipo){
        if(){

        }else{

        }
    }
}

public class Cuenta_corriente_en_dolares: Cuenta{
    public override void extraccion(double monto, tipo_de_extraccion tipo){
        
    }
}

public class Caja_ahorro_en_pesos: Cuenta{
    public override void extraccion(double monto, tipo_de_extraccion tipo){
        if(Balance_inicial <= 0){
            Console.WriteLine("No se puede realizar la extraccion, no tiene fondos");
        }else{
            if(tipo == tipo_de_extraccion.cajero_automatico){
                if(monto <= 10000){
                    Balance_inicial = Balance_inicial - monto;
                }else{
                    
                }
                
            }else{
                if 
            }
        }
    }
}

public enum tipo_de_extraccion{
    cajero_humano = 1,
    cajero_automatico = 2
}