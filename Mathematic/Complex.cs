namespace COM;

public class Complex{
    private int Real;
    private int Imag;

    public Complex(){
        this.Real=0;
        this.Imag=0;
    }

    public Complex(int Real,int Imag){
        this.Real=Real;
        this.Imag=Imag;
    }

    public int r{
        get{return this.Real;}
        set{this.Real=value;}
    }

    public int i{
        get{return this.Imag;}
        set{this.Imag=value;}
    }

    public static Complex operator+(Complex c1, Complex c2){
        Complex temp2=new Complex();
        temp2.Real=c1.Real+c2.Real;
        temp2.Imag=c1.Imag+c2.Imag;
        return temp2;
    }

    public static Complex operator-(Complex c1, Complex c2){
        Complex temp=new Complex();
        temp.Real=c1.Real-c2.Real;
        temp.Imag=c1.Imag-c2.Imag;
        return temp;
    }

     public static Complex operator*(Complex c1, Complex c2){
        Complex temp1=new Complex();
        temp1.Real=c1.Real*c2.Real;
        temp1.Imag=c1.Imag*c2.Imag;
        return temp1;
    }

    public override string ToString(){
        return this.Real+" "+this.Imag+"i";
    }
}