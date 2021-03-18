using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            myOponnent = new Oponnent(frontYard);
            ResetGame(false);
        }

        int Moves;

        Oponnent myOponnent;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHiddingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHiddingPlace hallway;
        RoomWithHiddingPlace bathroom;
        RoomWithHiddingPlace masterBedroom;
        RoomWithHiddingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        public void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "inside the closet");
            diningRoom = new RoomWithHiddingPlace("Dining Room", "a crystal chandeler", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door", "in the cabinet");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHiddingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHiddingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHiddingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHiddingPlace("Second Bedroom", "a small bed", "under the bed");


            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a bras knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };

            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();

        }
        private void RedrawForm()
        {
            cbExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cbExits.Items.Add(currentLocation.Exits[i].Name);               
            }
            cbExits.SelectedIndex = 0;

            txDescription.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";

            if (currentLocation is IHidingPlace) 
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                bt_check.Text = "Check " + hidingPlace.HidingPlaceName;
                bt_check.Visible = true;

            }
            else
                bt_check.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                btGoDoor.Visible = true;
            else
                btGoDoor.Visible = false;
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                txDescription.Text = "You found your opponent in " + Moves
                    + " moves! He was hidding " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            bt_check.Visible = false;
            btGoDoor.Visible = false;
            btGoHere.Visible = false;
            cbExits.Visible = false;
            bt_hide.Visible = true;


        }

        private void btGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cbExits.SelectedIndex]);
        }

        private void btGoDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void bt_hide_Click(object sender, EventArgs e)
        {
            bt_hide.Visible = false;

            for (int i = 0; i <= 10; i++)
            {
                myOponnent.Move();
                txDescription.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
                
            }

            txDescription.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            btGoHere.Visible = true;
            cbExits.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (myOponnent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }


    }
}
