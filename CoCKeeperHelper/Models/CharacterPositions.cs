using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    // Entity Model
    public class Character : PlaceHolder
    {
        public string Name { get; set; }

        public int ID { get; set; }
    }

    // Entity Model
    public class CharacterPosition
    {
        public int CharacterID { get; set; }
        public int Position { get; set; }
        public int ID { get; set; }
    }

    public class CharacterPositions : List<CharacterPosition>
    {
        public CharacterPositions()
        {
            var character1 = new CharacterPosition() { CharacterID = 1, Position = 0};
            this.Add(character1);

            var character2 = new CharacterPosition() { CharacterID = 2, Position = 3 };
            this.Add(character2);         
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
