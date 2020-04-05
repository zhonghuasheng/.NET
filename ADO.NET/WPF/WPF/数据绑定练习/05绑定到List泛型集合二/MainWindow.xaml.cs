using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _05绑定到List泛型集合二
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Human> People;
        private List<Animal> Animals;

        public MainWindow ( )
        {
            InitializeComponent();
            People = new List<Human> ( );
            People.Add ( new Human ( ) { ID = 1, Name = "Tom" } );
            People.Add ( new Human ( ) { ID = 2, Name = "Jerry" } );
            People.Add ( new Human ( ) { ID = 3, Name = "Mike" } );
            People.Add ( new Human ( ) { ID = 4, Name = "Lee" } );

            Animals = new List<Animal> ( );
            Animals.Add ( new Animal ( ) { ID = 1, Category = "Cat" } );
            Animals.Add ( new Animal ( ) { ID = 2, Category = "Tiger" } );
            Animals.Add ( new Animal ( ) { ID = 3, Category = "Dog" } );
            Animals.Add ( new Animal ( ) { ID = 4, Category = "Pig" } );
            Animals.Add ( new Animal ( ) { ID = 5, Category = "Cook" } );
            Animals.Add ( new Animal ( ) { ID = 6, Category = "Cow" } );

            lsLeft.ItemsSource = People;
            lsLeft.DisplayMemberPath = "Name";
            lsLeft.SelectedValuePath = "ID";

            lsRight.ItemsSource = Animals;
            lsRight.DisplayMemberPath = "Category";
            lsRight.SelectedValuePath = "ID";

            Binding binding = new Binding ( );
            binding.ElementName = "lsRight";
            binding.Path = new PropertyPath ( "SelectedValue" );
            lsLeft.SetBinding ( ListBox.SelectedValueProperty, binding );
        }
    }
}
