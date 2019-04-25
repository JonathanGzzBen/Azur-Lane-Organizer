using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

using AzurLane_Organizer.Entities;
namespace AzurLane_Organizer.Data
{
    class dataImageFiles
    {
        public dataImageFiles()
        {

        }

        private string CharactersDirectoryPath
        {
            get { return Directory.GetCurrentDirectory() + "\\Characters"; }
        }
        private string MainPictureDirectoryName
        {
            get { return "MainPictures"; }
        }

        private string ChibiPictureDirectoryName
        {
            get { return "ChibiPictures"; }
        }


        /// <summary>
        /// Returns image from a given path.
        /// </summary>
        /// <param name="imagePath">
        /// Image's path
        /// </param>
        /// <returns></returns>
        public Image GetImage(string imagePath)
        {
            try
            {
                using (Bitmap image = new Bitmap(imagePath))
                {
                    return new Bitmap(image);
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Saves a picture file in proper directory.
        /// Returns string with short path to that file.
        /// </summary>
        /// <param name="saveMainPicture">
        /// If true, the file will be saved in Main Picture
        /// directory. If false, it will be saved in Chibi Picture
        /// directory.
        /// </param>
        /// <param name="selectedImageFilePath">
        /// Path to the original image file.
        /// </param>
        /// <param name="characterId">
        /// CharacterId property of the character whose 
        /// picture file will be updated.
        /// </param>
        /// <returns></returns>
        public string SavePictureFile(bool saveMainPicture, string selectedImageFilePath , eCharacter character)
        {
            string selectedImagePath = selectedImageFilePath;
            string pictureDirectoryShortPath;
            if (saveMainPicture == true)
                pictureDirectoryShortPath = "\\" + MainPictureDirectoryName + "\\" + character.CharacterId.ToString();
            else
                pictureDirectoryShortPath = "\\" + ChibiPictureDirectoryName + "\\" + character.CharacterId.ToString();


            string pictureDirectoryFullPath = Directory.GetCurrentDirectory() + pictureDirectoryShortPath;
            try
            {
                if (Directory.Exists(pictureDirectoryFullPath))
                {
                    Directory.Delete(pictureDirectoryFullPath, true);
                }
                Directory.CreateDirectory(pictureDirectoryFullPath);
                string pictureFileShortPath = pictureDirectoryShortPath + "\\" + Path.GetFileName(selectedImagePath);
                string mainPictureFullFilePath = Directory.GetCurrentDirectory() + pictureFileShortPath;
                File.Copy(selectedImagePath, mainPictureFullFilePath, true);
                if (saveMainPicture == true)
                    character.MainPictureDirectory = pictureFileShortPath;
                else
                    character.ChibiPictureDirectory = pictureFileShortPath;
                //Should save changes in files to the database
                return pictureFileShortPath;
            }
            catch
            {
                return null;
            }
        }
    }
}
