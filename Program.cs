﻿// See https://aka.ms/new-console-template for more information
int a = 2;
int b = 3;
int sonuc = Topla(a,b);
//Console.WriteLine(sonuc);

Metotlar ornek = new Metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));

int sonuc2 = ornek.ArttirVeTopla(a,b);
ornek.EkranaYazdir(Convert.ToString(sonuc2));

static int Topla(int deger1, int deger2){
    return (deger1+deger2);
}

class Metotlar
{
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(int deger1, int deger2){
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}