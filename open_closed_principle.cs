// Problemática
public class AprovaExame {
    public void aprovarSolicitacaoExame(Exame exame){
        if(exame.tipo == SANGUE){
            if(verificaCondicoesExameSangue(exame))
                Console.WriteLine("Exame sanguíneo aprovado!");
        }
    }
    private boolean verificaCondicoesExameSangue(){
        //....
    }
}

// Se quisermos adicionar mais tipos de exames...
public class AprovaExame {
    public void aprovarSolicitacaoExame(Exame exame){
        if(exame.tipo == SANGUE){
            if(verificaCondicoesExameSangue(exame))
                Console.WriteLine("Exame sanguíneo aprovado!");
        }else if (exame.tipo == RaioX)
        {
            if(verificaCondicoesExameRaioX(exame))
                Console.WriteLine("Exame sanguíneo aprovado!");
        }
    }
    private boolean verificaCondicoesExameSangue(){
        // ...
    }

    private boolean verificaCondicoesExameRaioX()
    {
        // ...
    }
}

// Solução
// Abstrair os dados, construindo uma interface para identificação de tipo de exame genérica. 
public interface AprovaExame{
    void aprovarSolicitacaoExame(Exame exame);
    boolean verificaCondicoesExame(Exame exame);
}

public class AprovaExameSangue : AprovaExame{
    public void aprovarSolicitacaoExame(Exame exame){
            if(verificaCondicoesExame(exame))
                Console.WriteLine("Exame sanguíneo aprovado!");
    }
    boolean verificaCondicoesExame(Exame exame){
        //....
    }
}

public class AprovaRaioX : AprovaExame{
    public void aprovarSolicitacaoExame(Exame exame){
        if(verificaCondicoesExame(exame))
            Console.WriteLine("Raio-X aprovado!");
    }
    boolean verificaCondicoesExame(Exame exame){
        //....
    }
}