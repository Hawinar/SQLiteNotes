using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using SQLiteNotes.Classes;

/*
 Гайд на подключение БД SQLite:
 Качаем: Microsoft.EntityFrameworkCore.Sqlite, Microsoft.EntityFrameworkCore.Tools

 Переходим: Tools –> NuGet Package Manager –> Package Manager Console

 Вводим: Scaffold-DbContext "Data Source=C:\\Users\\Admin\\DB Browser for SQLite\\DataBases\\NoteDB.db" Microsoft.EntityFrameworkCore.Sqlite
 */

namespace SQLiteNotes.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        ApplicationContext db = new ApplicationContext();

        public MainMenu()
        {
            InitializeComponent();

            //Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Notes.Load();
            // и устанавливаем данные в качестве контекста
            DataContext = db.Notes.Local.ToObservableCollection();
        }

        private void lbTitles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Note? currentNote = lbTitles.SelectedItem as Note;
            if (currentNote != null)
            {
                tbText.Text = currentNote.Text;
                try
                {
                    tbText.FontFamily = new FontFamily(currentNote.FontFamily);
                    tbText.FontSize = currentNote.FontSize.Value;
                    lbLastChangeDate.Content = currentNote.DateLastChange;
                    tbNewTitle.Text = currentNote.Title;
                    tbFontFamily.Text = currentNote.FontFamily;
                    tbFontSize.Text = currentNote.FontSize.ToString();
                }
                catch (Exception)
                {
                    tbText.FontFamily = new FontFamily("Times New Roman");
                    tbText.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show("Загружен Times New Roman, а цвет покрашен в красный цвет", "Ошибка шрифта");
                }
            }

        }
        private void btAddNote_Click(object sender, RoutedEventArgs e)
        {
            if(tbNewNote.Text != string.Empty)
            {
                Note note = new Note();
                note.Title = tbNewNote.Text;
                note.Text = string.Empty;
                DateTime dateTime = DateTime.Now;
                note.DateLastChange = dateTime.ToString("dd-MM-yyyy HH:mm");
                note.FontFamily = "Times New Roman";
                note.FontSize = 14;
                try
                {
                    db.Add(note);
                    db.SaveChanges();
                    Refresh(note);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            
        }

        private void btDelNote_Click(object sender, RoutedEventArgs e)
        {

            Note note = lbTitles.SelectedItem as Note;
            if (note is null) return;
            db.Notes.Remove(note);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Удалено");
                Refresh(note);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            Note? currentNote = lbTitles.SelectedItem as Note;
            if (currentNote != null && tbNewTitle.Text != string.Empty)
            {
                try
                {
                    if (tbNewTitle.Text == string.Empty)
                        MessageBox.Show("Убедитесь, что название не пустое");
                    else
                    {
                        currentNote.Title = tbNewTitle.Text;
                        currentNote.Text = tbText.Text;
                        currentNote.FontFamily = tbFontFamily.Text;
                        currentNote.FontSize = long.Parse(tbFontSize.Text);

                        DateTime dateTime = DateTime.Now;
                        currentNote.DateLastChange = dateTime.ToString("dd-MM-yyyy HH:mm");
                        db.SaveChanges();
                        Refresh(currentNote);
                    }        
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
                MessageBox.Show("Выберите запись.");
        }
        private void Refresh(Note currentNote)
        {
            lbTitles.Items.Refresh();
            tbText.FontFamily = new FontFamily(currentNote.FontFamily);
            tbText.FontSize = currentNote.FontSize.Value;
            lbLastChangeDate.Content = currentNote.DateLastChange;
            tbNewTitle.Text = currentNote.Title;
            tbFontFamily.Text = currentNote.FontFamily;
            tbFontSize.Text = currentNote.FontSize.ToString();
        }


    }
}
