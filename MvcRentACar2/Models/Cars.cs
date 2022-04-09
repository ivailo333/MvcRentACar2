using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace MvcRentACar2.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }

        [DisplayName("Марка")]
        public int Marka { get; set; }

        [DisplayName("Модел")]
        public Model CarModel { get; set; }

        [DisplayName("Град")]
        public Cities City { get; set; }

        [DisplayName("Брой места")]
        public SeatCount CountSeat { get; set; }

        [DisplayName("Скоростна кутия")]
        public Transmission Transmission { get; set; }

        [DisplayName("Климатик")]
        public bool AirConditioning { get; set; }

        [DisplayName("Цена на ден")]
        public int Price { get; set; }

        [DisplayName("Брой коли")]
        public int CarCount { get; set; }
    }


    public enum Model
    {
        Седан,
        Хечбек,
        Лифтбек,
        Комби,
        Купе,
        Кабриолет,
        Лимузина,
        SUV,
        Кросоувър,
        Миниван,
        ван,
        Пекап,
        Джип
    }
    public enum Transmission
    {
        Автоматична,
        Ръчна
    }

    public enum SeatCount
    {
        Две=2,
        Пет=5,
        Седем=7,
        Осем=8
    }

    public enum Cities
    {
        Благоевград,
        Бургас,
        Варна,
        Велико_Търново,
        Видин,
        Враца,
        Габрово,
        Добрич,
        Кърджали,
        Кюстендил,
        Ловеч,
        Монтана,
        Пазарджик,
        Перник,
        Плевен,
        Пловдив,
        Разград,
        Русе,
        Силистра,
        Сливен,
        Смолян,
        Софийска,
        София,
        Стара_Загора,
        Търговище,
        Хасково,
        Шумен,
        Ямбол
    }

}
