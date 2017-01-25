package gui;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.SpringLayout.Constraints;

@Deprecated
public class View extends JFrame {

    private JButton btnHi;
    private JTextField txtHi;
    private JPanel pnl;

    public View() {
        super("cool :)");
        setSize(600, 700);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        btnHi = new JButton("Hello :D");
        txtHi = new JTextField("Cool", 3);
        pnl = new JPanel(new BorderLayout());
        pnl.add(btnHi, BorderLayout.NORTH);
        pnl.add(txtHi, BorderLayout.SOUTH);
        add(pnl);
        pack();
        show();
    }

}