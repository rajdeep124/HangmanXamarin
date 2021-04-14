using SQLite;

namespace HangmanXamarin.Classes
{
    //DATABASE MODEL
    [Table("Players")]
    class Player
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int HighScore { get; set; }


        //ToString override to help display player names on spinner without making a custom adapter.
        public override string ToString()
        {
            return this.Name;
        }
    }
}
