namespace Car_Rental.ViewModels
{
    public class CarRentalViewModel
    {
        public CarRentalViewModel()
        {
            this.Car = new CarViewModel();
        }

        public CarViewModel Car { get; set; }
    }
}