using MvvmCross.ViewModels;
using RPGsRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGsRepository.Core.ViewModels
{
    public class CardsViewModel : MvxViewModel
    {
        private MvxObservableCollection<Card> _cardList;
        public MvxObservableCollection<Card> CardList
        {
            get => _cardList;
            set
            {
                _cardList = value;
                RaisePropertyChanged(() => CardList);
            }
        }
    }
}
