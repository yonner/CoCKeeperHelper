using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCKeeperHelper.Data
{

    public interface PlaceHolder
    {

    }

    public class None : PlaceHolder
    {

    }

    public class Node : PlaceHolder
    {
        public int ID { get; set; }
    }

    public class Gap : PlaceHolder
    {

    }

    public class Character : PlaceHolder
    {
        public string Name { get; set; }
    }
    public class CharacterPositions : List<PlaceHolder>
    {
        public CharacterPositions()
        {
            var character1 = new Character() { Name = "Farmer" };
            this.Add(character1);

            var none = new None();
            this.Add(none);

            this.Add(none);

            var character2 = new Character() { Name = "Harvey" };
            this.Add(character2);

            this.Add(none);


            this.Add(none);
        }

    }

    public class ChasePath : List<PlaceHolder>
    {
        public ChasePath()
        {
            for (int i = 0; i < 5; i++)
            {
                var n1 = new Node() { ID = i };
                this.Add(n1);

                var g1 = new Gap();
                this.Add(g1);
            }
            var n2 = new Node() { ID = 5 };
            this.Add(n2);
        }
    }
}
