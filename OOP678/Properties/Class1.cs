using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OOP678
{
    class Shape //базовый класс с виртуальными методами
    {
        protected Color clr;
        public bool arrow;

        virtual public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для риосвания объекта
        {
        }
        virtual public bool isChecked(MouseEventArgs e)//проверка на выделенность
        {
            return false;
        }
        virtual public void move(PictureBox sender, int _x, int _y)//движение объекта
        {
        }
        virtual public void resize(PictureBox sender, int _d)//изменение размера
        {
        }
        virtual public void changeColor(Color _clr)//изменение цвета
        {
            clr = _clr;
        }
        virtual public void save(StreamWriter _file) //сохранение объекта в файл
        {
        }
        virtual public void load(StreamReader _file) //выгрузка данных об объекте из файла
        {
        }
        virtual public bool getF() //методы для выделения
        {
            return false;
        }
        virtual public void slect1()//метод1 для установки значения
        {
        }
        virtual public void slect2()//метод1 для установки значения
        {
        }
        virtual public bool isShapeArrow() //метод для стрелки
        {
            return arrow;
        }
        virtual public bool isArrowObjIntersectThis(Shape ArrowObj)
        {
            return false;
        }
    }
    class Secture : Shape //класс отрезок, унаследованный от базового класса 
    {
        private Point a, b; //точки
        private bool f;
        public float alfa; //коэф наклона
        public Secture(int _x1, int _y1, int _x2, int _y2, Color _clr) 
        {
            a.X = _x1;
            a.Y = _y1;
            b.X = _x2;
            b.Y = _y2;
            f = true;
            clr = _clr;
            if (b.X - a.X != 0)
            {
                alfa = (b.Y - a.Y) / (b.X - a.X); //коэфф наклона
            }
            else
            {
                alfa = 1000000;
            }

        }
        public override void save(StreamWriter _file) //сохранение данных
        {
            _file.WriteLine("L"); //пишем, что записываемый объект - отрезок
            _file.WriteLine(a.X); //записываем его данные
            _file.WriteLine(a.Y);
            _file.WriteLine(b.X);
            _file.WriteLine(b.Y);
            _file.WriteLine(alfa);
            _file.WriteLine(clr.ToKnownColor());
        }
        public override void load(StreamReader _file)//загрузка данных объекта
        {
            a.X = Convert.ToInt32(_file.ReadLine());
            a.Y = Convert.ToInt32(_file.ReadLine());
            b.X = Convert.ToInt32(_file.ReadLine());
            b.Y = Convert.ToInt32(_file.ReadLine());
            alfa = Convert.ToInt32(_file.ReadLine());
            clr = Color.FromName(_file.ReadLine());
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {

            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            g.DrawLine(pen, a, b);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender) //проверка на нахождение внутри области рисования
        {
            if ((a.X >= sender.Location.X + sender.Size.Width) || a.X <= sender.Location.X)
            {
                return false;
            }
            else if ((a.Y >= sender.Location.Y + sender.Size.Height) || a.Y <= sender.Location.Y)
            {
                return false;
            }
            else if ((b.X >= sender.Location.X + sender.Size.Width) || b.X <= sender.Location.X)
            {
                return false;
            }
            else if ((b.Y >= sender.Location.Y + sender.Size.Height) || b.Y <= sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender, int _x, int _y) //метод для передвижения
        {
            a.X = a.X + _x;
            a.Y = a.Y + _y;
            b.X = b.X + _x;
            b.Y = b.Y + _y;
            if (locationCheck(sender) == false)
            {
                a.X = a.X - _x;
                a.Y = a.Y - _y;
                b.X = b.X - _x;
                b.Y = b.Y - _y;
            }
        }
        public override void resize(PictureBox sender, int _d)//метод для изменения размера объекта
        {
            if (alfa != 0)
            {
                a.X = a.X + (int)alfa * _d;
                a.Y = a.Y - (int)alfa * _d;
                b.X = b.X - (int)alfa * _d;
                b.Y = b.Y + (int)alfa * _d;
                if (locationCheck(sender) == false)
                {
                    a.X = a.X - (int)alfa * _d;
                    a.Y = a.Y + (int)alfa * _d;
                    b.X = b.X + (int)alfa * _d;
                    b.Y = b.Y - (int)alfa * _d;
                }
            }
        }

        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {

            if (a.X > b.X)
            {
                if (a.Y < b.Y)
                {
                    if (e.X < a.X && e.X > b.X && e.Y > a.Y && e.Y < b.Y)
                    {
                        return true;
                    }
                }
                else if (a.Y > b.Y)
                {
                    if (e.X < a.X && e.X > b.X && e.Y < a.Y && e.Y > b.Y)
                    {
                        return true;
                    }
                }
            }
            else if (a.X < b.X)
            {
                if (a.Y < b.Y)
                {
                    if (e.X > a.X && e.X < b.X && e.Y > a.Y && e.Y < b.Y)
                    {
                        return true;
                    }
                }
                else if (a.Y > b.Y)
                {
                    if (e.X > a.X && e.X < b.X && e.Y < a.Y && e.Y > b.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }

    }
    class CSquare : Shape //класс квадрат, унаследованный от базового класса
    {
        private int x, y, l;
        private bool f;

        public CSquare(int _x, int _y, int _l, Color _clr)
        {
            x = _x;
            y = _y;
            l = _l;
            f = true;
            arrow = false;
            clr = _clr;
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public int getL() { return l; }
        public override void save(StreamWriter _file) //сохранение объекта
        {
            _file.WriteLine("R"); //пишем, что записываемый объект - квадрат
            _file.WriteLine(x); //записываем его данные
            _file.WriteLine(y);
            _file.WriteLine(l);
            _file.WriteLine(clr.ToKnownColor());
        }
        public override void load(StreamReader _file)//загрузка объекта
        {
            x = Convert.ToInt32(_file.ReadLine());
            y = Convert.ToInt32(_file.ReadLine());
            l = Convert.ToInt32(_file.ReadLine());
            clr = Color.FromName(_file.ReadLine());
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Rectangle rect = new Rectangle(x - l / 2, y - l / 2, l, l);
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            g.DrawRectangle(pen, rect);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender)
        {
            if ((x + l / 2 >= sender.Location.X + sender.Size.Width) || x - l / 2 <= sender.Location.X)
            {
                return false;
            }
            else if ((y + l / 2 >= sender.Location.Y + sender.Size.Height) || y - l / 2 <= sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender, int _x, int _y)//движение объекта
        {
            x = x + _x;
            y = y + _y;
            if (locationCheck(sender) == false)
            {
                x = x - _x;
                y = y - _y;
            }
        }
        public override void resize(PictureBox sender, int _d)//изменение размера объекта
        {
            l = l + _d / 2;
            if (locationCheck(sender) == false)
            {
                l = l - _d / 2;
            }
        }


        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            if (e.X >= x - l / 2 && e.Y >= y - l / 2 && e.X <= x + l / 2 && e.Y <= y + l / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }
    }
    class CTriangle : Shape // Теугольники
    {
        private Point a, b, c;
        private bool f;

        public CTriangle(int x1, int x2, int y1, int y2, int z1, int z2, Color _clr)
        {
            a = new Point(x1, x2);
            b = new Point(y1, y2);
            c = new Point(z1, z2);
            f = true;
            clr = _clr;
        }
        public override void save(StreamWriter _file) //сохранение объекта
        {
            _file.WriteLine("T"); //пишем, что записываемый объект - треугольник
            _file.WriteLine(a.X); //записываем его данные
            _file.WriteLine(a.Y);
            _file.WriteLine(b.X);
            _file.WriteLine(b.Y);
            _file.WriteLine(c.X);
            _file.WriteLine(c.Y);
            _file.WriteLine(clr.ToKnownColor());
        }
        public override void load(StreamReader _file)
        {
            a.X = Convert.ToInt32(_file.ReadLine());
            a.Y = Convert.ToInt32(_file.ReadLine());
            b.X = Convert.ToInt32(_file.ReadLine());
            b.Y = Convert.ToInt32(_file.ReadLine());
            c.X = Convert.ToInt32(_file.ReadLine());
            c.Y = Convert.ToInt32(_file.ReadLine());
            clr = Color.FromName(_file.ReadLine());
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            Point[] CurvePoints = { a, b, c };
            g.DrawPolygon(pen, CurvePoints);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender) //чтобы не вышло за границы
        {
            if ((b.X >= sender.Location.X + sender.Size.Width) || c.X <= sender.Location.X)
            {
                return false;
            }
            else if ((b.Y >= sender.Location.Y + sender.Size.Height) || a.Y <= sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender, int _x, int _y)//движение объекта
        {
            a.X += _x;
            a.Y += _y;
            b.X += _x;
            b.Y += _y;
            c.X += _x;
            c.Y += _y;
            if (locationCheck(sender) == false)
            {
                a.X -= _x;
                a.Y -= _y;
                b.X -= _x;
                b.Y -= _y;
                c.X -= _x;
                c.Y -= _y;
            }
        }
        public override void resize(PictureBox sender, int _d)//изменение размера объекта
        {
            a.Y = a.Y - _d / 2;
            b.X = b.X + _d / 2;
            b.Y = b.Y + _d / 2;
            c.X = c.X - _d / 2;
            c.Y = c.Y + _d / 2;
            if (locationCheck(sender) == false)
            {
                a.Y = a.Y + _d / 2;
                b.X = b.X - _d / 2;
                b.Y = b.Y - _d / 2;
                c.X = c.X + _d / 2;
                c.Y = c.Y - _d / 2;
            }
        }
        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            int p1 = (a.X - e.X) * (b.Y - a.Y) - (b.X - a.X) * (a.Y - e.Y);
            int p2 = (b.X - e.X) * (c.Y - b.Y) - (c.X - b.X) * (b.Y - e.Y);
            int p3 = (c.X - e.X) * (a.Y - c.Y) - (a.X - c.X) * (c.Y - e.Y);
            if ((p1 >= 0 && p2 >= 0 && p3 >= 0) || (p1 <= 0 && p2 <= 0 && p3 <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }
    }
    class CCircle : Shape //класс окружности, унаследованный от базового класса
    {
        private int x, y, r; //координаты и радиус
        private bool f; //булевая переменная, показывающая, "выделен" объект или нет
        public CCircle(int _x, int _y, int _r, Color _clr) //конструктор с параметрами
        {
            x = _x;
            y = _y;
            r = _r;
            f = true;
            clr = _clr;
            arrow = false;
        }
        public override bool isArrowObjIntersectThis(Shape ArrowShape)
        {
            if (ArrowShape is CCircle)
            {
                CCircle shape = (CCircle)ArrowShape;
                if (Math.Sqrt(Math.Pow(shape.getX() - this.x, 2) + Math.Pow(shape.getY() - this.y, 2)) <= (shape.getR() + this.r))
                {
                    return true;
                }
            }
            else if (ArrowShape is CSquare)
            {
                CSquare shape = (CSquare)ArrowShape;
                if (Math.Sqrt(Math.Pow(shape.getX() - this.x, 2) + Math.Pow(shape.getY() - this.y, 2)) <= (shape.getL() + this.r))
                {
                    return true;
                }
            }
            return false;
        }
        public int getX() { return x; }
        public int getY() { return y; }
        public int getR() { return r; }
        public override void save(StreamWriter _file) //сохранение объекта
        {
            _file.WriteLine("C"); //пишем, что записываемый объект - круг
            _file.WriteLine(x); //записываем его данные (координаты,радиус и цвет)
            _file.WriteLine(y);
            _file.WriteLine(r);
            _file.WriteLine(clr.ToKnownColor());
        }
        public override void load(StreamReader _file) //загрузка объекта
        {
            x = Convert.ToInt32(_file.ReadLine());
            y = Convert.ToInt32(_file.ReadLine());
            r = Convert.ToInt32(_file.ReadLine());
            clr = Color.FromName(_file.ReadLine());
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Rectangle rect = new Rectangle(x - r, y - r, r * 2, r * 2);
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            g.DrawEllipse(pen, rect);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender)//проверка объекта на нахождение в области риосования
        {
            if ((x + r >= sender.Location.X + sender.Size.Width) || x - r <= sender.Location.X)
            {
                return false;
            }
            else if ((y + r >= sender.Location.Y + sender.Size.Height) || y - r <= sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender, int _x, int _y)//движение объекта
        {
            x = x + _x;
            y = y + _y;
            if (locationCheck(sender) == false)
            {
                x = x - _x;
                y = y - _y;
            }
        }
        public override void resize(PictureBox sender, int _d)//изменение размера объекта
        {
            r = r + _d / 2;
            if (locationCheck(sender) == false)
            {
                r = r - _d / 2;
            }
        }
        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            if (((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)) <= (r * r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }
    }
    class CShapeFactory // фабрика
    {
        public Shape createShape(char code)
        {
            Shape shape = null;
            switch (code)
            {
                case 'C':
                    shape = new CCircle(0, 0, 0, Color.Black);
                    break;
                case 'R':
                    shape = new CSquare(0, 0, 0, Color.Black);
                    break;
                case 'T':
                    shape = new CTriangle(0, 0, 0, 0, 0, 0, Color.Black);
                    break;
                case 'L':
                    shape = new Secture(0, 0, 0, 0, Color.Black);
                    break;
                case 'G':
                    shape = new CGroup(0);
                    break;
                default:
                    break;

            }
            return shape;
        }
    }
    class Storage //контейнер
    {
        private int _maxcount;
        private int _count;
        public Shape[] _storage;
        public System.EventHandler observers;
        public Storage(int maxcount)//конструктор с параметрами
        {
            _maxcount = maxcount; _count = 0;
            _storage = new Shape[_maxcount];
            for (int i = 0; i < _maxcount; i++)
                _storage[i] = null;
        }

        public void saveObjs() //функция сохранения хранилища в файл
        {
            string path = @"C:\oop7\data.txt"; //путь до файла
            StreamWriter cfile = new StreamWriter(path, false); //создаем записыватель файла
            cfile.WriteLine(_count); //записываем размер хранилища
            for (int i = 0; i < _count; i++)
            {
                if (_storage[i] != null) //если объект существует
                {
                    {
                        _storage[i].save(cfile); //сохраняем его
                    }
                }
            }
            cfile.Close();
        }
        public void loadObjs() //выгрузка объектов из файла в хранилище
        {
            string path = @"C:\oop7\data.txt"; //путь до файла
            CShapeFactory factory = new CShapeFactory(); //factory для создания объектов
            StreamReader sr = new StreamReader(path); //читатель файла
            char code;  //код, определяюший тип объекта
            _count = Convert.ToInt32(sr.ReadLine());//считываем первую строку с количеством элементов
            _maxcount = 100;
            _storage = new Shape[_maxcount]; //создаем хранилище определенного размера
            for (int i = 0; i < _count; i++)
            {
                code = Convert.ToChar(sr.ReadLine()); //считываем тип объекта
                _storage[i] = factory.createShape(code); //factory создает объект определенного типа
                if (_storage[i] != null)
                {
                    _storage[i].load(sr); //считываем информацию о объекте из файла
                }
            }
            sr.Close(); //закрываем файл

        }
        public void addObj(Shape obj) //добавление объекта
        {
            if (_count >= _maxcount)//если превышено макс значение
            {
                Array.Resize(ref _storage, _count + 1);
                _storage[_count] = obj;
                _storage[_count].slect1();
                for (int i = 0; i < _count - 1; i++)
                {
                    _storage[i].slect2();
                }
                _count++;
                _maxcount++;
            }
            else if (_count == 0)
            {
                _count++;
                _storage[_count - 1] = obj;
                _storage[_count - 1].slect1();
            }
            else
            {
                _count++;
                _storage[_count - 1] = obj;
                for (int i = 0; i < _count - 1; i++)
                {
                    _storage[i].slect2();
                }
            }
        }
        public void deleteObj(int index)//удаление объекта
        {
            _storage[index] = null;
            for (int i = index + 1; i < _count; i++)//идем с места удаления объекта к концу массива и перемещаем объекты 
            {
                _storage[i - 1] = _storage[i];
            }
            _storage[_count - 1] = null;
            _count--;
        }
        public void methodObj(PictureBox sender, int index, Bitmap bmp, Graphics g) //вызов draw у объекта по индексу
        {
            if (_storage[index] != null)
            {
                _storage[index].draw(sender, bmp, g);
            }
        }
        public void moveObj(PictureBox sender, int _x, int _y)//движение объектов
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null) 
                {
                    if (_storage[i].getF() == true)
                    {
                        if (_storage[i].isShapeArrow() == true)
                        {
                            for (int j = _count - 1; j >= 0; j--)
                            {
                                if (i != j)
                                {
                                    if (_storage[j].isArrowObjIntersectThis(_storage[i]) == true)
                                    {
                                        _storage[j].move(sender, _x, _y);
                                    }
                                }
                            }
                        }
                        _storage[i].move(sender, _x, _y);
                    }

                }
            }
        }
        public void makeObjArrow()
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i].getF() == true)
                {
                    _storage[i].arrow = true;
                }
            }
        }
        public void resizeObj(PictureBox sender, int _d)//изменение размера
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].resize(sender, _d);
                    }
                }
            }
        }
        public void changeObjColor(Color _clr)//изменение цвета
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].changeColor(_clr);
                    }
                }
            }
        }

        public int getCount() //получение количества объектов в хранилище (на форме)
        {
            return _count;
        }
        public void allObjFalse()  //все объекты перестают быть выделенными
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].slect2();
                    }
                }

            }
        }
        public void allObjTrue()  //все объекты перестают быть выделенными
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == false)
                    {
                        _storage[i].slect1();
                    }
                }

            }
        }
        public void deleteWhenDel() //удаление выделенных объектов при нажатии кнопки Delete
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        deleteObj(i);
                    }
                }
            }
        }
        public bool checkInfo1(MouseEventArgs e) //проверка того, нажат ли объект на форме, если клавиша Ctrl не нажата
        {
            for (int i = 0; i < getCount(); i++)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].isChecked(e) == true)
                    {
                        allObjFalse();
                        _storage[i].slect1();
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        public bool checkInfo2(MouseEventArgs e) //проверка того, нажат ли объект на форме, если клавиша Ctrl нажата
        {
            for (int i = 0; i < getCount(); i++)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].isChecked(e) == true)
                    {
                        _storage[i].slect1();
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        public void createIntersectGroup(int one, int two)
        {
            CGroup group = new CGroup(2);
            group.addObj(_storage[one]);
            group.addObj(_storage[two]);
            deleteObj(one);
            deleteObj(two);
            addObj(group);
        }
        public void createGroup() //метод создания группы
        {
            int sum = 0; //количество выделенных объектов
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        sum++; //если объект выделен, то sum увеличиваем
                    }
                }
            }
            if (sum >= 2) //если выделено больше одного объекта
            {
                CGroup group = new CGroup(sum); //создаем группу
                for (int i = _count - 1; i >= 0; i--)
                {
                    if (_storage[i] != null)
                    {
                        if (_storage[i].getF() == true) //если объект выделен
                        {
                            group.addObj(_storage[i]); //добавляем его в группу                           
                            deleteObj(i);              //удаляем объект из хранилища
                        }
                    }
                }
                addObj(group);//добавляем заполненную группу в хранилище
            }
        }
        public void deleteGroup() //метод удаления группы (разгруппировка)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i] is CGroup && _storage[i].getF() == true)
                    {
                        CGroup tgroup = (CGroup)_storage[i];
                        for (int j = tgroup.getCount() - 1; j >= 0; j--)
                        {
                            addObj(tgroup._group[j]);
                            tgroup.deleteObj(j);
                        }
                        deleteObj(i); //удаление группы из хранилища
                    }
                }
            }
        }
        public Shape getSelectedShape() // получение выделенных объектов
        {
            Shape selected = null;
            for (int i = 0; i < _count; i++)
            {
                if (_storage[i].getF() == true)
                {
                    selected = _storage[i];
                    return selected;
                }
                else if (_storage[i].getF() == false && _storage[i] is CGroup)
                {
                    CGroup group = (CGroup)_storage[i];
                    selected = group.getSelectedShape(ref selected);
                    if (selected != null)
                    {
                        return selected;
                    }
                }
            }
            return selected;
        }
        public void processNode(TreeNode tn, Shape[] s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != null)
                {
                    if (s[i] is CCircle)
                    {
                        str = "Круг";

                    }
                    else if (s[i] is CSquare)
                    {
                        str = "Квадрат";
                    }
                    else if (s[i] is CTriangle)
                    {
                        str = "Треугольник";
                    }
                    else if (s[i] is Secture)
                    {
                        str = "Отрезок";
                    }
                    else if (s[i] is CGroup)
                    {
                        str = "Группа";
                    }
                    tn.Nodes.Add(new TreeNode(str));
                    tn.Nodes[i].Tag = s[i];
                    if (s[i] is CGroup)
                    {
                        CGroup group = (CGroup)s[i];
                        processNode(tn.Nodes[i], group._group);
                    }
                }
            }
        }
        public void treeNodeSelect(TreeNode treeNode)
        {
            allObjFalse();
            for (int i = 0; i < _count; i++)
            {
                //если объект наш самый
                if (_storage[i] == treeNode.Tag)
                {
                    _storage[i].slect1();
                }
                //если объект не наш самый но это группа
                else if (_storage[i] != treeNode.Tag && _storage[i] is CGroup)
                {
                    CGroup group = (CGroup)_storage[i];
                    group.treeNodeSelect(treeNode);
                }
            }
        }
    }
    class CGroup : Shape
    {
        private int _maxcount;
        private int _count;
        private bool f;
        public Shape[] _group;
        public CGroup(int maxcount)
        {
            _maxcount = maxcount; _count = 0;
            _group = new Shape[_maxcount];
            f = true;
            for (int i = 0; i < _maxcount; i++)
                _group[i] = null;
        }
        ~CGroup()
        {
            for (int i = 0; i < _count; i++)
            {
                _group[i] = null;
            }
            _group = null;
        }
        public Shape getSelectedShape(ref Shape selected)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_group[i].getF() == true)
                {
                    selected = _group[i];
                    return selected;
                }
                else if (_group[i].getF() == false && _group[i] is CGroup)
                {
                    CGroup group = (CGroup)_group[i];
                    selected = group.getSelectedShape(ref selected);
                    if (selected != null)
                    {
                        return selected;
                    }
                }
            }
            return selected;
        }
        public void treeNodeSelect(TreeNode treeNode)
        {
            allObjFalse();
            for (int i = 0; i < _count; i++)
            {
                if (_group[i] == treeNode.Tag)
                {
                    _group[i].slect1();
                }
                //если объект не наш но это группа
                else if (_group[i] != treeNode.Tag && _group[i] is CGroup)
                {
                    CGroup group = (CGroup)_group[i];
                    group.treeNodeSelect(treeNode);
                }
            }
        }
        public int getCount()
        {
            return _count;
        }
        public bool addObj(Shape obj) //добавление объекта
        {
            if (_count >= _maxcount)
            {
                return false;
            }
            _count++;
            _group[_count - 1] = obj;
            return true;
        }
        public void deleteObj(int index)
        {
            _group[index] = null;
            for (int i = index + 1; i < _count; i++)
            {
                _group[i - 1] = _group[i];
            }
            _group[_count - 1] = null;
            _count--;
        }
        public override void save(StreamWriter _file) //сохранение объекта
        {
            _file.WriteLine("G"); //пишем, что записываемый объект - группа
            _file.WriteLine(_count); //записываем размер группы
            for (int i = 0; i < _count; i++)
            {
                if (_group[i] != null) //если объект существует
                {
                    {
                        _group[i].save(_file); //сохраняем его
                    }
                }
            }
        }
        public override void load(StreamReader _file) //загрузка объектов
        {
            CShapeFactory factory = new CShapeFactory(); //factory для создания объектов
            char code;  //код, определяюший тип объекта
            _count = Convert.ToInt32(_file.ReadLine());
            _group = new Shape[_count]; //создаем хранилище определенного размера
            for (int i = 0; i < _count; i++)
            {
                code = Convert.ToChar(_file.ReadLine()); //считываем тип объекта
                _group[i] = factory.createShape(code); //factory создает объект определенного типа
                if (_group[i] != null)
                {
                    _group[i].load(_file); //считываем информацию о объекте из файла
                }
            }
        }
        public override void draw(PictureBox sender, Bitmap bmp, Graphics g)
        {
            for (int i = 0; i < _count; i++)
            {
                _group[i].draw(sender, bmp, g);
            }
        }
        public override void move(PictureBox sender, int _x, int _y)
        {
            for (int i = 0; i < _count; i++)
            {
                _group[i].move(sender, _x, _y);
            }
        }
        public override void changeColor(Color _clr)
        {
            for (int i = 0; i < _count; i++)
            {
                _group[i].changeColor(_clr);
            }
        }
        public override void resize(PictureBox sender, int _d)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_group[i] != null)
                {
                    _group[i].resize(sender, _d);
                }
            }
        }
        public override bool isChecked(MouseEventArgs e)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_group[i] != null)
                {
                    if (_group[i].isChecked(e) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void allObjFalse()
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                _group[i].slect2();
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
            for (int i = 0; i < _count; i++)
            {
                _group[i].slect1();
            }
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
            allObjFalse();
        }
    }
    class myTreeView : TreeView
    {
        private Storage storage;

        public void addStorage(Storage _storage) //позволяет установить значение переменной storage 
        {
            storage = _storage;
        }
        public void notifyStorage(TreeNode treeNode) //обновляет состояние хранилища на основе выбранного узла дерева
        {
            storage.treeNodeSelect(treeNode);
            //storage.Change
            //если что-то в дереве выбираем, то тут делаем так
            //чтобы и в хранилище менялось


        }
        //Метод objSelectRecursive рекурсивно проходит через узлы дерева, начиная с treeNode,
        //и проверяет, соответствует ли Tag узла указанной shape.
        //Если соответствует, то устанавливает данный узел в качестве выбранного узла.
        public void objSelectRecursive(TreeNode treeNode, Shape shape)
        {
            if (treeNode.Tag == shape)
            {
                treeNode.TreeView.SelectedNode = treeNode;
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                objSelectRecursive(tn, shape);
            }
        }

        //Метод callRecursive проходит через все узлы в treeView
        //и вызывает метод objSelectRecursive для каждого узла с указанной shape.
        //Это позволяет установить выбранный узел для каждого узла дерева,
        //который соответствует указанной форме.
        public void callRecursive(myTreeView treeView, Storage s)
        {
            Shape shape = s.getSelectedShape();
            foreach (TreeNode n in treeView.Nodes)
            {
                objSelectRecursive(n, shape);
            }
        }
    }
}
