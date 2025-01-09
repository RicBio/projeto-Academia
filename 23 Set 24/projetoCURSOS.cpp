//projeto CURSOS
//MODEL
#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Classe Aluno
class Aluno {
public:
    int id;
    string nome;
    vector<string> disciplinasMatriculadas;

    Aluno(int id, string nome) : id(id), nome(nome) {}

    // Função que verifica se o aluno pode se matricular em mais disciplinas
    bool podeMatricular() {
        return disciplinasMatriculadas.size() < 6;
    }
};

// Classe Disciplina
class Disciplina {
public:
    int id;
    string descricao;
    vector<Aluno> alunos;

    Disciplina(int id, string descricao) : id(id), descricao(descricao) {}

    // Matricular aluno na disciplina
    bool matricularAluno(Aluno& aluno) {
        if (alunos.size() < 15 && aluno.podeMatricular()) {
            alunos.push_back(aluno);
            aluno.disciplinasMatriculadas.push_back(descricao);
            return true;
        }
        return false;
    }

    // Desmatricular aluno da disciplina
    bool desmatricularAluno(Aluno& aluno) {
        for (auto it = alunos.begin(); it != alunos.end(); ++it) {
            if (it->id == aluno.id) {
                alunos.erase(it);
                return true;
            }
        }
        return false;
    }
};

// Classe Curso
class Curso {
public:
    int id;
    string descricao;
    vector<Disciplina> disciplinas;

    Curso(int id, string descricao) : id(id), descricao(descricao) {}

    // Adicionar disciplina no curso
    bool adicionarDisciplina(Disciplina& disciplina) {
        if (disciplinas.size() < 12) {
            disciplinas.push_back(disciplina);
            return true;
        }
        return false;
    }

    // Pesquisar disciplina no curso
    Disciplina* pesquisarDisciplina(int disciplinaId) {
        for (auto& disciplina : disciplinas) {
            if (disciplina.id == disciplinaId) {
                return &disciplina;
            }
        }
        return nullptr;
    }

    // Remover disciplina do curso
    bool removerDisciplina(int disciplinaId) {
        for (auto it = disciplinas.begin(); it != disciplinas.end(); ++it) {
            if (it->id == disciplinaId && it->alunos.empty()) {
                disciplinas.erase(it);
                return true;
            }
        }
        return false;
    }
};

// Classe Escola
class Escola {
public:
    vector<Curso> cursos;

    // Adicionar curso na escola
    bool adicionarCurso(Curso& curso) {
        if (cursos.size() < 5) {
            cursos.push_back(curso);
            return true;
        }
        return false;
    }

    // Pesquisar curso na escola
    Curso* pesquisarCurso(int cursoId) {
        for (auto& curso : cursos) {
            if (curso.id == cursoId) {
                return &curso;
            }
        }
        return nullptr;
    }

    // Remover curso da escola
    bool removerCurso(int cursoId) {
        for (auto it = cursos.begin(); it != cursos.end(); ++it) {
            if (it->id == cursoId && it->disciplinas.empty()) {
                cursos.erase(it);
                return true;
            }
        }
        return false;
    }
};
//VIEW
void mostrarMenu() {
    cout << "Selecione uma opcao: " << endl;
    cout << "0. Sair" << endl;
    cout << "1. Adicionar curso" << endl;
    cout << "2. Pesquisar curso" << endl;
    cout << "3. Remover curso" << endl;
    cout << "4. Adicionar disciplina no curso" << endl;
    cout << "5. Pesquisar disciplina" << endl;
    cout << "6. Remover disciplina do curso" << endl;
    cout << "7. Matricular aluno na disciplina" << endl;
    cout << "8. Remover aluno da disciplina" << endl;
    cout << "9. Pesquisar aluno" << endl;
}
//CONTROLLER
class Controller {
private:
    Escola escola;

public:
    void executar() {
        int opcao;
        do {
            mostrarMenu();
            cin >> opcao;

            switch(opcao) {
                case 1: {
                    // Adicionar curso
                    int id;
                    string descricao;
                    cout << "ID do curso: ";
                    cin >> id;
                    cout << "Descricao do curso: ";
                    cin.ignore();
                    getline(cin, descricao);
                    Curso novoCurso(id, descricao);
                    if (escola.adicionarCurso(novoCurso)) {
                        cout << "Curso adicionado com sucesso." << endl;
                    } else {
                        cout << "Nao foi possivel adicionar o curso." << endl;
                    }
                    break;
                }

                case 2: {
                    // Pesquisar curso
                    int id;
                    cout << "ID do curso: ";
                    cin >> id;
                    Curso* curso = escola.pesquisarCurso(id);
                    if (curso) {
                        cout << "Curso: " << curso->descricao << endl;
                        cout << "Disciplinas:" << endl;
                        for (const auto& disciplina : curso->disciplinas) {
                            cout << "- " << disciplina.descricao << endl;
                        }
                    } else {
                        cout << "Curso nao encontrado." << endl;
                    }
                    break;
                }

                // Outras opções seguem lógica similar para disciplinas e alunos

                case 0:
                    cout << "Saindo..." << endl;
                    break;

                default:
                    cout << "Opcao invalida!" << endl;
            }

        } while(opcao != 0);
    }
};
//MAIN
int main() {
    Controller controller;
    controller.executar();
    return 0;
}
