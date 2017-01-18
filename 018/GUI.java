import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class GUI extends JFrame implements ActionListener
{
    private BasicAccountList accounts;
    private JPanel buttonPanel;
    private JPanel textPanel;
    private JButton jbtAdd;
    private JButton jbtNumber;
    private JButton jbtQuit;
    private JLabel jlbAcctNo;
    private JLabel jlbFName;
    private JLabel jlbLName;
    private JTextField jtfAcctNo;
    private JTextField jtfFName;
    private JTextField jtfLName;
    private static int nextAcctNo;

    static public void main(String[] args)
    {
        System.out.println("Hi");
    }
    
    public GUI()
    {
        super("GUI");
        accounts = new BasicAccountList();
        nextAcctNo = 1000;
        makeFrame();
    }

    private void createButtonPanel()
    {
        buttonPanel = new JPanel(new GridLayout());
        jbtAdd = new JButton("Add Account");
        jbtAdd.addActionListener(this);

        jbtNumber = new JButton("No. of Accounts");
        jbtNumber.addActionListener(this);

        jbtQuit = new JButton("Quit");
        jbtQuit.addActionListener(this);

        buttonPanel.add(jbtAdd);
        buttonPanel.add(jbtNumber);
        buttonPanel.add(jbtQuit);
    }

    private void createTextPanel()
    {
        textPanel = new JPanel(new GridLayout(3, 2));
        jlbFName = new JLabel("First Name:", SwingConstants.RIGHT);
        jlbLName = new JLabel("Last Name:", SwingConstants.RIGHT);
        jlbAcctNo = new JLabel("Account Number:", SwingConstants.RIGHT);

        jtfFName = new JTextField();
        jtfLName = new JTextField();
        jtfAcctNo = new JTextField();
        jtfAcctNo.setEditable(false);
        jtfAcctNo.setHorizontalAlignment(SwingConstants.CENTER);

        textPanel.add(jlbFName);
        textPanel.add(jtfFName);
        
        textPanel.add(jlbLName);
        textPanel.add(jtfLName);
       
        textPanel.add(jlbAcctNo);
        textPanel.add(jtfAcctNo);
    }

    private void makeFrame()
    {
        setSize(400, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        createButtonPanel();
        createTextPanel();
        add(textPanel, BorderLayout.CENTER);
        add(buttonPanel, BorderLayout.SOUTH);
        showFrame();
    }

    private void showFrame()
    {
        setLocationRelativeTo(null);
        setVisible(true);
    }

    public void actionPerformed(ActionEvent e)
    {
        //Handle the QUIT Button
        if(e.getSource().equals(jbtQuit))
        {
            System.exit(0);
        }
        //Handdle the NUMBER OF ACCOUNTS BUTTON
        else if(e.getSource().equals(jbtNumber) && jbtNumber.getText().equals("No. of Accounts"))
        {
            jbtAdd.setEnabled(false);
            //If there are no accounts, enable the Add Account button.
            if(accounts.getNumberOfAccounts() == 0)
            {
                jtfAcctNo.setText("0");
                jbtAdd.setEnabled(true);
            }
            jtfAcctNo.setText(String.valueOf(accounts.getNumberOfAccounts()));
            jlbAcctNo.setText("No. of accounts:");
            jbtNumber.setText("Clear");
        }
        //Handle the CLEAR BUTTON
        else if(e.getSource().equals(jbtNumber) && jbtNumber.getText().equals("Clear"))
        {
            jbtNumber.setText("No. of Accounts");
            jlbAcctNo.setText("Account Number:");
            jtfAcctNo.setText("");
            jbtNumber.setEnabled(false);
            jbtAdd.setEnabled(true);
        }
        //Handle the ADD ACCOUNT BUTTON
        else if(e.getSource().equals(jbtAdd) && jbtAdd.getText().equals("Add Account"))
        {
            //Check If both text boxes are empty
            if(jtfFName.getText().isEmpty() && jtfLName.getText().isEmpty())
            {
                jtfAcctNo.setText("No names");
            }
            //If there is no first name.
            else if(jtfFName.getText().isEmpty() && !jtfLName.getText().isEmpty())
            {
                jtfAcctNo.setText("No first name");
            }
            //If there is no last name
            else if(!jtfFName.getText().isEmpty() && jtfLName.getText().isEmpty())
            {
                jtfAcctNo.setText("No last name");
            }
            else
            {
                //Generate Account Number
                nextAcctNo++;
                jtfAcctNo.setText(String.valueOf(nextAcctNo));
                jbtAdd.setText("Confirm");
                jbtNumber.setEnabled(false);
            }
        }
        //Handle the CONFIRM BUTTON
        else if(e.getSource().equals(jbtAdd) && jbtAdd.getText().equals("Confirm"))
        {
            //Add the Account to  the arraylist
            accounts.addAccount(new BasicAccount(jtfFName.getText(), jtfLName.getText(), jtfAcctNo.getText()));

            jtfFName.setText("");
            jtfLName.setText(""); //clear text fields
            jtfAcctNo.setText("");

            jbtAdd.setText("Add Account");
            jbtNumber.setEnabled(true);
        }
    }
}
