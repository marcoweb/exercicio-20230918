public class Personagem {
    private string _tipo;
    private int _posX;
    private int _posY;

    public string Tipo {
        get {return this._tipo;}
        set {this._tipo = value;}
    }
    public int PosX {
        get {return this._posX;}
        set {this._posX = value;}
    }
    public int PosY {
        get {return this._posY;}
        set {this._posY = value;}
    }
}