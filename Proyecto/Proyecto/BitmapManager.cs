using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class BitmapManager
{
    // Guardar la imagen
    public static void GuardarImagen(Bitmap bm, string path)
    {
        try
        {
            // Determinar el formato de la imagen según la extensión del archivo
            ImageFormat format = ImageFormat.Png; // Por defecto, PNG
            string extension = Path.GetExtension(path).ToLower();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    format = ImageFormat.Jpeg; 
                    break;
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".png":
                    format = ImageFormat.Png; 
                    break;
                default:
                    throw new NotSupportedException("Formato no soportado."); 
            }

            bm.Save(path, format); 
        }
        catch (Exception ex)
        {
            throw new IOException("Error al guardar la imagen: " + ex.Message); // Manejo de errores
        }
    }

    public static Bitmap CargarImagen(string path)
    {
        try
        {
            // Cargar la imagen desde el archivo
            return new Bitmap(path); 
        }
        catch (Exception ex)
        {
            throw new IOException("Error al cargar la imagen: " + ex.Message); // Manejo de errores
        }
    }
}
