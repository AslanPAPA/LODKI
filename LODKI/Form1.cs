using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace LODKI
{
    public partial class Form1 : Form
    {
        private string[] standardModels = {
            "Дуб",
            "Береза",
            "Ель"
        };

        private string[] economyModels = {
            "Сосна",
            "Лиственница"
        };

        private string[] luxuryModels = {
            "Красное дерево",
            "Тик"
        };

        private string[] standardEquipment = {
            "Черпак",
            "Весла",
            "Спасательный жилет"
        };

        private string[] economyEquipment = {
            "Черпак",
            "Весла"
        };

        private string[] luxuryEquipment = {
            "Навес",
            "Зонтик",
            "Холодильник",
            "Спасательный жилет"
        };

        private string[] standardColor = {
            "Коричневый",
            "Белый",
            "Черный",
            "Зеленый",
            "Красный",
            "Синий"
        };

        private string[] economyColor = {
            "Пурпурный",
            "Серый"
        };

        private string[] luxuryColor = {
            "Серобуромалиновый",
            "Хромотический",
            "Золотой"
        };

        private string[] standardSheap = {
            "Шлюпка"
        };

        private string[] economySheap = {
            "Парусная лодка"
        };

        private string[] luxurySheap = {
            "Галера"
        };

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Инициализация ComboBox (аналог ChoiceBox в JavaFX)
            choiceAssort.Items.AddRange(new string[] {
                "Стандартные модели",
                "Модели эконом класса",
                "Модели класса Люкс"
            });

            // Настройка колонок DataGridView (аналог TableView)
            orderNumColumn.DataPropertyName = "OrderNum";
            assortColumn.DataPropertyName = "Assort";
            treeColumn.DataPropertyName = "Tree";
            sheapColumn.DataPropertyName = "Sheap";
            colorColumn.DataPropertyName = "Color";
            oborColumn.DataPropertyName = "Obor";

            // Подписка на событие выбора
            choiceAssort.SelectedIndexChanged += (sender, e) => UpdateChoices();
        }

        private void UpdateChoices()
        {
            if (choiceAssort.SelectedItem == null) return;

            string selectedAssort = choiceAssort.SelectedItem.ToString();

            choiceSheap.Items.Clear();
            choiceObor.Items.Clear();
            choiceColor.Items.Clear();
            choiceSheap.Items.Clear();

            switch (selectedAssort)
            {
                case "Стандартные модели":
                    choiceSheap.Items.AddRange(standardModels);
                    choiceObor.Items.AddRange(standardEquipment);
                    choiceColor.Items.AddRange(standardColor);
                    choiceSheap.Items.AddRange(standardSheap);
                    break;
                case "Модели эконом класса":
                    choiceSheap.Items.AddRange(economyModels);
                    choiceObor.Items.AddRange(economyEquipment);
                    choiceColor.Items.AddRange(economyColor);
                    choiceSheap.Items.AddRange(economySheap);
                    break;
                case "Модели класса Люкс":
                    choiceSheap.Items.AddRange(luxuryModels);
                    choiceObor.Items.AddRange(luxuryEquipment);
                    choiceColor.Items.AddRange(luxuryColor);
                    choiceSheap.Items.AddRange(luxurySheap);
                    break;
            }
        }

        private void OnOrderBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choiceAssort.SelectedItem == null ||
                choiceSheap.SelectedItem == null ||
                choiceSheap.SelectedItem == null ||
                choiceColor.SelectedItem == null ||
                choiceObor.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед созданием заказа.",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            int randOrder = random.Next(100, 1000);
            string orderNum = randOrder.ToString();

            string assort = choiceAssort.SelectedItem.ToString();
            string tree = choiceSheap.SelectedItem.ToString();
            string sheap = choiceSheap.SelectedItem.ToString();
            string color = choiceColor.SelectedItem.ToString();
            string obor = choiceObor.SelectedItem.ToString();

            var order = new Order
            {
                OrderNum = orderNum,
                Assort = assort,
                Tree = tree,
                Sheap = sheap,
                Color = color,
                Obor = obor
            };

            // Добавление в DataGridView
            var bindingList = new BindingList<Order>();
            if (tableView.DataSource != null)
            {
                bindingList = (BindingList<Order>)tableView.DataSource;
            }
            bindingList.Add(order);
            tableView.DataSource = bindingList;
        }
    }

    // Класс Order для хранения данных
    public class Order
    {
        public string OrderNum { get; set; }
        public string Assort { get; set; }
        public string Tree { get; set; }
        public string Sheap { get; set; }
        public string Color { get; set; }
        public string Obor { get; set; }
    }
}