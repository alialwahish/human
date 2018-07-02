using System;

namespace Human{

    public class Human{
        public string name;
        public int strength,intelligence,dexterity,health;

        public Human(string name){
            this.name=name;
            strength=dexterity=intelligence=3;
            health=100;

        }
        public Human(string name, int strength,int intelligence,int dexterity,int health){
            this.name=name;
            this.strength=strength;
            this.intelligence=intelligence;
            this.dexterity=dexterity;
            this.health=health;
        }        

        public string attack(object def){
             
            if(def is Human){

            Human rhs=(Human)def;
            this.strength-=1;
            rhs.health-=5;
            return this.name+"attacked "+rhs;
            }
            else {
                Console.WriteLine("Error passed value is not a Human Obj");
                return "Error passed value is not a Human Obj";
                }

            
        }

        public string ToString(){

            return "Name: "+name+" health: "+health+" strength: "+strength;
        }

        
    }
}