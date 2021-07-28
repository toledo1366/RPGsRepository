using System;
using MvvmCross.ViewModels;
using RPGsRepo.Core.Models;

namespace RPGsRepo.Core.ViewModels
{
    public class CardCreationViewModel:MvxViewModel
    {
        public CardCreationViewModel()
        {
        }

        private DnDCard _card;
        public DnDCard Card
        {
            get => _card;
            set
            {
                _card = value;
                RaisePropertyChanged(()=> Card);
            }
        }
    }
}
