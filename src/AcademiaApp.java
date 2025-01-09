import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import com.google.gson.Gson;

public class AcademiaApp {
    // Campos de entrada
    private JTextField txtNome, txtIdade, txtPeso, txtAltura, txtObjetivo;

    public AcademiaApp() {
        // Configuração da janela
        JFrame frame = new JFrame("Cadastro de Aluno - Academia");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 300);
        frame.setLayout(new GridLayout(7, 2));

        // Componentes da interface
        JLabel lblNome = new JLabel("Nome:");
        txtNome = new JTextField();

        JLabel lblIdade = new JLabel("Idade:");
        txtIdade = new JTextField();

        JLabel lblPeso = new JLabel("Peso:");
        txtPeso = new JTextField();

        JLabel lblAltura = new JLabel("Altura:");
        txtAltura = new JTextField();

        JLabel lblObjetivo = new JLabel("Objetivo:");
        txtObjetivo = new JTextField();

        JButton btnIncluir = new JButton("Incluir");
        JButton btnLimpar = new JButton("Limpar");
        JButton btnApresentar = new JButton("Apresenta Dados");
        JButton btnSair = new JButton("Sair");

        // Adicionando componentes à janela
        frame.add(lblNome);
        frame.add(txtNome);
        frame.add(lblIdade);
        frame.add(txtIdade);
        frame.add(lblPeso);
        frame.add(txtPeso);
        frame.add(lblAltura);
        frame.add(txtAltura);
        frame.add(lblObjetivo);
        frame.add(txtObjetivo);
        frame.add(btnIncluir);
        frame.add(btnLimpar);
        frame.add(btnApresentar);
        frame.add(btnSair);

        // Configurando eventos
        btnIncluir.addActionListener(e -> incluirDados());
        btnLimpar.addActionListener(e -> limparCampos());
        btnApresentar.addActionListener(e -> apresentarDados());
        btnSair.addActionListener(e -> System.exit(0));

        frame.setVisible(true);
        inicializarBancoDeDados();
    }

    private void incluirDados() {
        String nome = txtNome.getText();
        int idade = Integer.parseInt(txtIdade.getText());
        float peso = Float.parseFloat(txtPeso.getText());
        float altura = Float.parseFloat(txtAltura.getText());
        String objetivo = txtObjetivo.getText();

        try (Connection conn = DriverManager.getConnection("jdbc:sqlite:academia.db");
                PreparedStatement stmt = conn.prepareStatement(
                        "INSERT INTO Aluno (nome, idade, peso, altura, objetivo) VALUES (?, ?, ?, ?, ?)")) {
            stmt.setString(1, nome);
            stmt.setInt(2, idade);
            stmt.setFloat(3, peso);
            stmt.setFloat(4, altura);
            stmt.setString(5, objetivo);
            stmt.executeUpdate();
            JOptionPane.showMessageDialog(null, "Dados incluídos com sucesso!");
        } catch (Exception ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(null, "Erro ao incluir os dados: " + ex.getMessage());
        }
    }

    private void limparCampos() {
        txtNome.setText("");
        txtIdade.setText("");
        txtPeso.setText("");
        txtAltura.setText("");
        txtObjetivo.setText("");
    }

    private void apresentarDados() {
        try (Connection conn = DriverManager.getConnection("jdbc:sqlite:academia.db");
                Statement stmt = conn.createStatement();
                ResultSet rs = stmt.executeQuery("SELECT * FROM Aluno")) {
            Gson gson = new Gson();
            StringBuilder dadosJson = new StringBuilder();
            while (rs.next()) {
                Aluno aluno = new Aluno(
                        rs.getString("nome"),
                        rs.getInt("idade"),
                        rs.getFloat("peso"),
                        rs.getFloat("altura"),
                        rs.getString("objetivo"));
                dadosJson.append(gson.toJson(aluno)).append("\n");
            }
            JOptionPane.showMessageDialog(null, dadosJson.toString());
        } catch (Exception ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(null, "Erro ao apresentar os dados: " + ex.getMessage());
        }
    }

    private void inicializarBancoDeDados() {
        try (Connection conn = DriverManager.getConnection("jdbc:sqlite:academia.db");
                Statement stmt = conn.createStatement()) {
            stmt.execute("CREATE TABLE IF NOT EXISTS Aluno (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "nome TEXT, idade INTEGER, peso REAL, altura REAL, objetivo TEXT)");
        } catch (Exception ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(null, "Erro ao inicializar o banco de dados: " + ex.getMessage());
        }
    }

    public static void main(String[] args) {
        new AcademiaApp();
    }
}

class Aluno {
    private String nome;
    private int idade;
    private float peso;
    private float altura;
    private String objetivo;

    public Aluno(String nome, int idade, float peso, float altura, String objetivo) {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
        this.altura = altura;
        this.objetivo = objetivo;
    }
}
