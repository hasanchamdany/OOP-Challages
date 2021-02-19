using System;
    namespace OOPfundamental
    {
        class kendaraan
        {
            string Merk;
            string Model;
            double hp;
            bool turbo;

             public kendaraan(string Merk, string Model, double hp, bool turbo = false){
                this.Merk = Merk;
                this.Model = Model;
                this.hp = hp;
                this.turbo = turbo;
            }
             public void GetSpec(){
                 Console.WriteLine(" {0} - {1} memiliki {2} horse power, turbo = {3}", Merk, Model, hp, turbo);
             }
             public double GetVelocity(double hp, bool turbo){
                 double Velocity = 0;
                 Velocity = (hp/4) * 1.5 + 100;
                 if(this.turbo == true){
                     Velocity = Velocity + 0.1 * Velocity;
                 } 
                 return Velocity;
             }
        }
    }