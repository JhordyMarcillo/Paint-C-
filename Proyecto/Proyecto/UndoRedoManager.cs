using System;
using System.Collections.Generic;
using System.Drawing;

namespace Proyecto
{
    public class UndoRedoManager
    {
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();

        public void GuardarEstado(Bitmap bm)
        {
            Bitmap copia = new Bitmap(bm);
            undoStack.Push(copia);
            redoStack.Clear();  // Limpiar la pila
        }

        //Metodo para deshacer los cambios
        public Bitmap Deshacer(Bitmap bm)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(bm));
                bm = undoStack.Pop();
            }
            else
            {
                //Manejo de excepciones
                throw new InvalidOperationException("No hay cambios para deshacer.");
            }

            return bm;
        }

        //Metodo para deshacer los cambios
        public Bitmap Rehacer(Bitmap bm)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new Bitmap(bm));
                bm = redoStack.Pop();
            }
            else
            {
                //Manejo de excepciones
                throw new InvalidOperationException("No hay cambios para rehacer.");
            }

            return bm;
        }
    }
}
