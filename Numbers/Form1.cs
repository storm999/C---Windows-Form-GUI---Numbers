using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int amountOfNumbers = 30;
        bool inserted = false;          // Used for avoiding mixing list after insertion
        bool isStatsCalled = false;     // Used fo avoiding dublicated log generation

        private void showStats(string occuredEvent)
        {
            if(listBox.Items.Count > 0)     //Avoids execption after deleting last element
            {
                logs.Items.Add(DateTime.Now.ToString());
                logs.Items.Add("Occured Event: " + occuredEvent);
                logs.Items.Add("First number: " + listBox.Items[0]);
                logs.Items.Add("Last number: " + listBox.Items[listBox.Items.Count - 1]);
                logs.Items.Add("Biggest number: " + findBiggest());
                logs.Items.Add("");
            }
            else if(listBox.Items.Count == 0)
            {
                logs.Items.Add(DateTime.Now.ToString());
                logs.Items.Add("Occured Event: " + occuredEvent);
                logs.Items.Add("Last element was deleted");
                logs.Items.Add("");
            }    
        }

        private void enableButtons()    // Enable correct/required buttons 
        {
            if(listBox.Items.Count == 0)
            {
                insert.Enabled = true;
                insertBox.Enabled = true;
            }
            if (listBox.Items.Count >= 1)
            {
                clear.Enabled = true;
                delete.Enabled = true;
                search.Enabled = true;
                searchTextBox.Enabled = true;
                linearSearch.Enabled = true;
                if (listBox.Items.Count != amountOfNumbers && isSorted())
                {
                    sortedInsert.Enabled = true;
                    insertBox.Enabled = true;
                    insert.Enabled = true;
                }
                if (listBox.Items.Count >= 2 && listBox.Items.Count <= amountOfNumbers)
                {
                    unsorted.Enabled = true;
                    sort.Enabled = true;
                    shuffle.Enabled = true;
                    if(listBox.Items.Count < amountOfNumbers)
                    {
                        insert.Enabled = true;
                        insertBox.Enabled = true;
                    }
                }
            }
        }

        private void disableButtons()   // Disable correct/required buttons
        {
            if (listBox.Items.Count <= 1)
            {
                unsorted.Enabled = false;
                sort.Enabled = false;
                shuffle.Enabled = false;

                if (listBox.Items.Count == 0)
                {
                    search.Enabled = false;
                    binarySearch.Enabled = false;
                    linearSearch.Enabled = false;
                    searchTextBox.Enabled = false;
                    clear.Enabled = false;
                    delete.Enabled = false;
                    sortedInsert.Enabled = false;
                }
            }
            else if (listBox.Items.Count >= amountOfNumbers)
            {
                insert.Enabled = false;
                insertBox.Enabled = false;
                sortedInsert.Enabled = false;
            }
        }

        private void unsortedSelections()    //Selects proper radio buttons when list is unsorted
        {
            if (listBox.Items.Count >= 2)
            {
                linearSearch.Checked = true;
                binarySearch.Enabled = false;
                unsorted.Checked = true;
                sortedInsert.Enabled = false;
                sortedInsert.Checked = false;
            }
        }

        private void sortedSelections()     //Selects proper radio buttons when list is sorted
        {
            if (listBox.Items.Count >= 1)
            {
                binarySearch.Checked = true;
                binarySearch.Enabled = true;
                sort.Checked = true;
                if (listBox.Items.Count != amountOfNumbers)
                {
                    sortedInsert.Enabled = true;
                }
            }
        }
        
        private int binaryInsert(long insertKey)     // Finds correct place for the number that will be insterted to sorted list
        {
            int lowerBound = 0;
            int upperBound = listBox.Items.Count - 1;

            while (true)
            {
                int currentInsert = (upperBound + lowerBound) / 2;
                if (listBox.Items.Count == 0)
                {
                    return currentInsert = 0;
                }
                if (lowerBound == currentInsert)
                {
                    if (Convert.ToInt32(listBox.Items[currentInsert]) > insertKey)
                    {
                        return currentInsert;
                    }
                }
                if (Convert.ToInt32(listBox.Items[currentInsert]) < insertKey)
                {
                    lowerBound = currentInsert + 1;          // its in the upper 
                    if (lowerBound > upperBound)
                    {
                        return currentInsert += 1;
                    }
                }
                else if (lowerBound > upperBound)
                {
                    return currentInsert;
                }
                else
                {
                    upperBound = currentInsert - 1;          // its in the lower   
                }
                if (Convert.ToInt32(listBox.Items[currentInsert]) == insertKey)
                {
                    return -1;
                }
            }
        }

        private bool isSorted()     //checks if list is sorted or not
        {
            for (int i = 0; i < listBox.Items.Count - 1; i++)
            {
                if (Convert.ToInt32(listBox.Items[i]) > Convert.ToInt32(listBox.Items[i + 1]))
                    return false;
            }
            return true;
        }

        private int linearSearchF(int searched)     //makes linear search in the list
        {
            for (int i = 0; i < Convert.ToInt32(listBox.Items.Count); i++)
            {
                if (searched == Convert.ToInt32(listBox.Items[i]))
                {
                    return i + 1;
                }
            }
            return -1;
        }

        private int binarySearchF(int searched)     //makes binary seatch in the list
        {
            int low = 0;
            int high = listBox.Items.Count - 1;

            while (high >= low)
            {
                int middle = (low + high) / 2;
                if (Convert.ToInt32(listBox.Items[middle]) == searched)
                {
                    return middle + 1;
                }
                if (Convert.ToInt32(listBox.Items[middle]) < searched)
                {
                    low = middle + 1;
                }
                if (Convert.ToInt32(listBox.Items[middle]) > searched)
                {
                    high = middle - 1;
                }
            }
            return -1;
        }

        private void mySort()   //sorts the list by using buble sort
        {
            if (listBox.Items.Count > 1)
            {
                bool swapped;
                do
                {
                    int counter = listBox.Items.Count - 1;
                    swapped = false;

                    while (counter > 0)
                    {
                        // Compare the items' length. 
                        if (Convert.ToInt32(listBox.Items[counter])
                            < Convert.ToInt32(listBox.Items[counter - 1]))
                        {
                            // Swap the items.
                            object temp = listBox.Items[counter];
                            listBox.Items[counter] = listBox.Items[counter - 1];
                            listBox.Items[counter - 1] = temp;
                            swapped = true;
                        }
                        // Decrement the counter.
                        counter -= 1;
                    }
                }
                while ((swapped == true));
            }
        }

        private void myMixer()      // mixes numbers in the list
        {
            if (listBox.Items.Count > 1)
            {
                object temp;
                int mixer;
                Random rnd = new Random();

                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    temp = listBox.Items[i];
                    mixer = rnd.Next(1, listBox.Items.Count);
                    listBox.Items[i] = listBox.Items[mixer];
                    listBox.Items[mixer] = temp;
                }
            }
        }

        private void operationsAfterDelete()    // called  when a number is deleted from list
        {
            enableButtons();
            disableButtons();

            if (isSorted())
            {
                sortedSelections();
            }
            else
            {
                unsortedSelections();
            }
        }

        private int findBiggest()       // finds the biggest number in the list to show in stats panel
        {
            if (isSorted())
                return Convert.ToInt32(listBox.Items[Convert.ToInt32(listBox.Items.Count - 1)]);    //executed when list is sorted
            else if (listBox.Items.Count > 0)                                                          //executed when list is unsorted
            {
                int max = Convert.ToInt32(listBox.Items[0]);
                for (int i = 1; i < listBox.Items.Count; i++)
                {
                    if (max < Convert.ToInt32(listBox.Items[i]))
                        max = Convert.ToInt32(listBox.Items[i]);
                }
                return max;
            }
            else
                return -1;
        }

        private void randomGen_Click(object sender, EventArgs e)       // random generate button     
        {
            try                             // TRY CATCH FOR checking if it is convertable to int or not
            {
                int howMany = Convert.ToInt32(howManyy.Text);

                if ((listBox.Items.Count + howMany) > amountOfNumbers)
                {
                    if ((amountOfNumbers - listBox.Items.Count) == 0)
                        MessageBox.Show("Seems list box is already full.\nPlease try to delete something first.");
                    else
                        MessageBox.Show("List can store max " + amountOfNumbers + " integers.\nPlease enter a number smallar than " + (amountOfNumbers +1 - listBox.Items.Count));
                }
                else if ((listBox.Items.Count + howMany) <= amountOfNumbers && howMany >= 1)
                {
                    Random rnd = new Random();

                    for (int i = 0; i < howMany; i++)
                    {
                        int temp = rnd.Next(0, 101);
                        if (linearSearchF(temp) == -1)
                            listBox.Items.Add(temp);
                        else
                            howMany++;
                    }
                    isStatsCalled = true;
                    unsortedSelections();
                    enableButtons();
                    disableButtons();
                    isStatsCalled = false;
                    showStats("Random Generation");
                }
                else
                    MessageBox.Show("Seems you entered a negative value or zero.\nPlease enter a positive integer.");
            }
            catch (Exception)
            {
                MessageBox.Show("An Exception occured.\nProbably it was not a valid integer");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)    //sorted radio button
        {
            if (sort.Checked)
            {
                mySort();
                if(!isStatsCalled)
                    showStats("Sorted Radio Button Selected");
                isStatsCalled = true;
                sortedSelections();
                isStatsCalled = false;
            }
        }

        private void sortedGen_Click(object sender, EventArgs e)        //sorted initializer
        {
            listBox.Items.Clear();
            try
            {
                int howMany = Convert.ToInt32(howManyy.Text);

                if ((listBox.Items.Count + howMany) > amountOfNumbers)
                {
                    if ((amountOfNumbers - listBox.Items.Count) == 0)
                        MessageBox.Show("Seems list box is already full.\nPlease try to delete something first.");
                    else
                        MessageBox.Show("List can store max amountOfNumbers integers.\nPlease enter a number smallar than " + (amountOfNumbers + 1 - listBox.Items.Count));
                }
                else if ((listBox.Items.Count + howMany) <= amountOfNumbers && howMany >= 1)
                {
                    Random rnd = new Random();
                    double sortedTemp = 0;

                    for (int i = 0; i < howMany; i++)
                    {
                        int temp = Convert.ToInt32(sortedTemp) + rnd.Next(0, 100 / howMany);
                        listBox.Items.Add(temp);
                        sortedTemp = sortedTemp + Convert.ToDouble(101) / Convert.ToDouble(howMany);
                    }
                    isStatsCalled = true;
                    enableButtons();
                    disableButtons();
                    sortedSelections();
                    isStatsCalled = false;
                    showStats("Sorted Initialization");
                }
                else
                    MessageBox.Show("Seems you entered a negative value or zero.\nPlease enter a positive integer.");
            }
            catch (Exception)
            {
                MessageBox.Show("An Exception occured.\nProbably it was not a valid integer");
            }
        }

        private void shuffle_Click(object sender, EventArgs e)  //shuffle button
        {
            myMixer();
            isStatsCalled = true;
            unsortedSelections();
            showStats("Shuffle Button Clicked");
            isStatsCalled = false;
        }

        private void clear_Click(object sender, EventArgs e)    // clear button
        {
            listBox.Items.Clear();
            disableButtons();
            enableButtons();
        }

        private void insert_Click(object sender, EventArgs e)   // insert button
        {
            try                     // TRY CATCH FOR checking if it is convertable to int or not
            {
                if (insertBox.Text == "Insert" || insertBox.Text=="")
                {
                    MessageBox.Show("You haven't entered a number.");
                    return;
                }

                int insert = Convert.ToInt32(insertBox.Text);
                if (insert > 100 || insert < 0)
                {
                    MessageBox.Show("Please enter a integer between 0 and 100.");
                    return;
                }
                else
                {
                    if (sortedInsert.Checked)
                    {
                        if (binarySearchF(insert) != -1)
                            MessageBox.Show("This number already exist in the list.\nPlease enter another number.");
                        else
                        {
                            listBox.Items.Insert(binaryInsert(insert), insert);
                            insertBox.ForeColor = Color.Gray;
                            insertBox.Text = "Insert";
                        }
                    }
                    else
                    {
                        if (linearSearchF(insert) != -1)
                            MessageBox.Show("This number already exist in the list.\nPlease enter another number.");
                        else
                        {
                            listBox.Items.Add(insert);
                            insertBox.ForeColor = Color.Gray;
                            insertBox.Text = "Insert";
                        }
                    }
                    isStatsCalled = false;
                    showStats("Insertion");
                    isStatsCalled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception error.\nProbably it wasnt a valid integer");
            }

            if (listBox.Items.Count >= 2 && !isSorted())
            {
                inserted = true;
                unsortedSelections();

            }
            else if (listBox.Items.Count >= 2 && isSorted())
            {
                sortedSelections();
            }
            enableButtons();
            disableButtons();
            isStatsCalled = false;
        }      

        private void delete_Click(object sender, EventArgs e)   //delete button
        {
            listBox.Items.Remove(listBox.SelectedItem);

            isStatsCalled = true;
            operationsAfterDelete();
            isStatsCalled = false;
            showStats("Deletion via Button");
        }

        private void unsorted_CheckedChanged(object sender, EventArgs e)    //unsorted radio button
        {
            if (unsorted.Checked)
            {
                if (inserted == false)
                {
                    myMixer();
                }
                else
                {
                    inserted = false;
                }
                if(isStatsCalled == false)
                {
                    showStats("Unsorted Radio Button Clicked");
                }
                isStatsCalled = true;
                unsortedSelections();
                isStatsCalled = false;
            }
        }

        private void exit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void search_Click(object sender, EventArgs e)   //search button
        {
            if (binarySearch.Checked)
            {
                int temp = -1;
                temp = binarySearchF(Convert.ToInt32(searchTextBox.Text));

                if (temp == -1)
                    MessageBox.Show("Number doesn't exist in the list.");
                else
                    MessageBox.Show("Number is " + temp + " th element of the list");
            }
            else if (linearSearch.Checked)
            {
                int temp = -1;
                temp = linearSearchF(Convert.ToInt32(searchTextBox.Text));

                if (temp == -1)
                    MessageBox.Show("Number doesn't exist in the list.");
                else
                    MessageBox.Show("Number is " + temp + " th element of the list");
            }
        }

        private void genInsertSorted_Click(object sender, EventArgs e)      //sorted generate button
        {
            try
            {
                int howMany = Convert.ToInt32(howManyy.Text);

                if ((listBox.Items.Count + howMany) > amountOfNumbers)
                {
                    if ((amountOfNumbers - listBox.Items.Count) == 0)
                        MessageBox.Show("Seems list box is already full.\nPlease try to delete something first.");
                    else
                        MessageBox.Show("List can store max " + amountOfNumbers + " integers.\nPlease enter a number smallar than " + (amountOfNumbers + 1 - listBox.Items.Count));
                }
                else if ((listBox.Items.Count + howMany) <= amountOfNumbers && howMany >= 1)
                {
                    if (!isSorted())
                        mySort();
                    Random rnd = new Random();

                    for (int i = 0; i < howMany; i++)
                    {
                        int temp = rnd.Next(0, 101);
                        int countBeforeInsert = listBox.Items.Count;
                        int isThere = binaryInsert(temp);

                        if (isThere == -1)
                        {
                            howMany++;
                        }
                        else
                        {
                            listBox.Items.Insert(isThere, temp);
                        }
                    }
                    isStatsCalled = true;
                    enableButtons();
                    disableButtons();
                    sortedSelections();
                    isStatsCalled = false;
                    showStats("Sorted Generation");
                }
                else
                    MessageBox.Show("Seems you entered a negative value or zero.\nPlease enter a positive integer.");
            }
            catch (Exception)
            {
                MessageBox.Show("An Exception occured.\nProbably it was not a valid integer");
            }
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)     // selects a number from listbox for deleting it via dragging to bin
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBox.Items.Count == 0)
                {
                    return;
                }
                if(listBox.SelectedItem != null)
                {
                    listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.All);
                }
            }
        }
    
        private void toolStripContainer3_ContentPanel_DragDrop(object sender, DragEventArgs e)      // deletes number after drop
        {
            listBox.Items.Remove(listBox.SelectedItem);

            isStatsCalled = true;
            operationsAfterDelete();
            isStatsCalled = false;
            showStats("Deletion via Dragging");
            
        }

        private void toolStripContainer3_ContentPanel_DragEnter_1(object sender, DragEventArgs e)   // makes container dropable
        {
            e.Effect = DragDropEffects.All;
        }

        // Arranges colors of default texts in textboxes
        private void howManyy_Leave(object sender, EventArgs e)
        {
            if (howManyy.Text == "")
            {
                howManyy.ForeColor = Color.Gray;
                howManyy.Text = "How Many";
            }
        }

        private void howManyy_Enter(object sender, EventArgs e)
        {
            if (howManyy.Text == "How Many")
            {
                howManyy.Clear();
                howManyy.ForeColor = Color.Black;
            }
        }

        private void insertBox_Enter(object sender, EventArgs e)
        {
            if (insertBox.Text == "Insert")
            {
                insertBox.Clear();
                insertBox.ForeColor = Color.Black;
            }
        }

        private void insertBox_Leave(object sender, EventArgs e)
        {
            if (insertBox.Text == "")
            {
                insertBox.ForeColor = Color.Gray;
                insertBox.Text = "Insert";
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Clear();
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.ForeColor = Color.Gray;
                searchTextBox.Text = "Search";
            }
        }
    }
}

