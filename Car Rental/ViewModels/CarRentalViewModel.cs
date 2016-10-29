namespace Car_Rental.ViewModels
{
    public class CarRentalViewModel
    {
        public CarRentalViewModel()
        {
            this.Car = new CarViewModel();
            this.Rental = new RentalModel();
        }

        public CarViewModel Car { get; set; }

        public RentalModel Rental { get; set; }
    }
}