using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Monster
{
    class Monster
    {
        public int hp;

        int _maxHp;

        public int maxHp
        {
            get
            {
                return _maxHp;
            }
        }

        int _attack;

        public int attack
        {
            get
            {
                return _attack;
            }
        }

        string _name;

        public string name
        {
            get
            {
                return _name;
            }
        }

        int _healPower;

        public int healPower
        {
            get
            {
                return _healPower;
            }
        }

        public Monster(int hp, int attack, string name, int healPower = 0)
        {
            this.hp = hp;
            _attack = attack;
            _name = name;
            _maxHp = hp;
            _healPower = healPower;

            mostra();
        }

        private void mostra()
        {
            Console.WriteLine("Si è aggiunto all'arena " + _name + "   ATK:" + _attack + "   HP:" + this.hp );
        }
        
        private bool deathTest()
        {
            if (this.hp <= 0)
            {
                Console.WriteLine
                    ("Vecchio, non sei Gesù Cristo, sei morto. Fine. Basta. Ok? Non puoi fare un cazzo."
                    + " Hai perso. Finiscila con questo gioco di merda e fatti una vita. Nerd del cazzo."
                    + " Piuttosto vatti a fare due seghe no? Dai... Non venirmi a dire 'e se avessi una ragazza?'"
                    + " perché uno come te una figa non l'ha mai vista...");
                return true;
            }
            else return false;
        }

        public void heal(Monster ally)
        {
            if (deathTest()) { return; }    
            if (healPower == 0) { Console.WriteLine("Non hai poteri curativi (HA! sfigato!!!)"); }  
            if (ally.hp < ally.maxHp)
            {
                ally.hp += this.healPower;
                if (ally.hp > ally.maxHp)
                {
                    ally.hp = ally.maxHp;
                }
            }
            else
            {
                Console.WriteLine("Non puoi dopare il tuo alleato...");
            }
        }

        public void damage(Monster enemy)
        {
            if (deathTest()) { return; }
            if (enemy.hp > 0)
            {
                enemy.hp = enemy.hp - this.attack;
                Console.WriteLine(this.name + " fa l'infame e accoltella malamente " + enemy.name);
                if (enemy.hp <= 0)
                {
                    enemy.hp = 0;
                    Console.WriteLine(enemy.name + " è morto (lol)");
                }
            }
            else
            {
                Console.WriteLine("Ti diverti a sodomizzare il povero " + enemy.name + " con un bastoncino");
            }
        }
        
    }
}
