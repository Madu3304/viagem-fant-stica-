using voyage_fantastique;

Tela tela = new Tela();
BancoDados bancoDados = new BancoDados();
AssistirCRUD assistir = new AssistirCRUD(bancoDados, tela);
DiretorCCRUD diretor = new DiretorCRUD(bancoDados, tela);
MaduCRUD madu = new MaduCRUD(bancoDados, tela);
NotesCRUD notes = new NotesCRUD(bancoDados, tela);
OpniaoCRUD opniao = new OpniaoCRUD(bancoDados tela);
SuivantCRUD suivant = new SuivantCRUD(bancoDados, tela);
Ziu10CRUD ziu10 = new Ziu10CRUD(bancoDados, tela);

List<string> menu = new List<string>();
menu.Add("1 - Assistir  ");
menu.Add("2 - Diretor   ");
menu.Add("3 - Madu      ");
menu.Add("4 - Notes     ");
menu.Add("5 - Opniao    ");
menu.Add("6 - Suivant   ");
menu.Add("7 - Ziu10     ");

string op;

while (true)
{
    tela.montarTelaSistema("Tempo Juntos");
    op = tela.mostrarMenu(menu, 5, 5);

    if (op == "0") break;
    if (op == "1") assistir.executarCRUD();
    if (op == "2") diretor.execultarCRUD();
    if (op == "3") madu.execultarCRUD();
    if (op == "4") notes.execultarCRUD();
    if (op == "5") opniao.execultarCRUD();
    if (op == "6") suivant.execultarCRUD();
    if (op == "7") ziu10.execultarCRUD();
}