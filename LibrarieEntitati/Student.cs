using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[][] note=new int[4][];

        // contructor implicit
        public Student()
        {
            for (int i = 0; i < 4; i++)
                note[i] = new int[15];
            
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
            for (int i = 0; i < 4; i++)
                note[i] = new int[15];
        }

        public void SetNote(string sirNote)
        {
            
            // initializare vector cu note
            string[] note_split = sirNote.Split(',');
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note
    
            string[] splitNota;
            int contor_an = 0;
            
            foreach(var nota in note_split)
            {
                int contor_coloana = 0;
                splitNota = nota.Split(' ');
                foreach(var nota_an in splitNota)
                {
                    note[contor_an][contor_coloana] = Convert.ToInt32(nota_an);

                    contor_coloana++;
                }
                contor_an++;  
                
            }
        }

        public void SetNoteRand(int[] note, int nrnote, int an)
        {
            Array.Resize(ref this.note[an], this.note[an].Length + nrnote);

            for (int i = 0; i < nrnote; i++)
            {
                this.note[an][i] = note[i];
            }
        }

        public void ConversieLaSir()
        {
            string afisare;
            Console.WriteLine("Studentul {0} are notele : ...", nume);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Notele din anul {0}", i + 1);
                afisare = string.Join(",", note[i]);
                Console.WriteLine(afisare);

            }
        }


    }
}
