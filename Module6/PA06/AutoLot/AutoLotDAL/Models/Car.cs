/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: PA06-3
 */

namespace AutoLotDAL.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
