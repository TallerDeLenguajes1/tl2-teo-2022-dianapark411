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
        if(tipo == tipo_de_extraccion.cajero_automatico){
            if(monto <= 200){ //hacer bien control del dia xq hasta aca solo contempla el monto de una extraccion
                Balance_inicial = Balance_inicial - monto;
                Console.WriteLine("Extraccion exitosa");
            }else{
                Console.WriteLine("No se pueden extraer mas de 200 usd por dia en cajero automatico");
            }                
        }else{
            if (tipo == tipo_de_extraccion.cajero_humano){
                Balance_inicial = Balance_inicial - monto;
                Console.WriteLine("Extraccion exitosa");
            }
        }
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
                    Console.WriteLine("Extraccion exitosa");
                }else{
                    Console.WriteLine("No se pueden extraer mas de 10000 por cajero automatico");
                }                
            }else{
                if (tipo == tipo_de_extraccion.cajero_humano){
                    Balance_inicial = Balance_inicial - monto;
                    Console.WriteLine("Extraccion exitosa");
                }
            }
        }
    }
}

public enum tipo_de_extraccion{
    cajero_humano = 1,
    cajero_automatico = 2
}