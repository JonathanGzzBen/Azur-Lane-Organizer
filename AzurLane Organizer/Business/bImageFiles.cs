using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.IO;

using AzurLane_Organizer.Data;
using AzurLane_Organizer.Entities;

namespace AzurLane_Organizer.Business
{
    class bImageFiles
    {
        private dataImageFiles _dataImageFiles = new dataImageFiles();

        public bImageFiles()
        {

        }

        public Image GetImage(string imagePath)
        {
            Image selectedImage = _dataImageFiles.GetImage(imagePath);
            if (selectedImage == null)
            {
                MessageBox.Show("There was an error getting image file", "Could not get image",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _dataImageFiles.GetImage(imagePath);
        }

        public string SavePictureFile(bool changeMainPicture, string selectedImageFilePath , eCharacter character)
        {
            return _dataImageFiles.SavePictureFile(changeMainPicture, selectedImageFilePath, character);
        }

    }
}
