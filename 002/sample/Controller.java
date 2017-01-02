package sample;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.MenuItem;
import javafx.stage.Stage;

public class Controller {

    @FXML
    private Button btnOne;

    @FXML
    private Button btnTwo;

    @FXML
    private Button btnThree;

    @FXML
            private MenuItem muClose;


    Double opacity = 0.99;

    @FXML
    private void btnOne_Click() {
        System.out.println("One");
        Stage s = Main.getPrimaryStage();
        s.getScene().getStylesheets().add("css/red.css");


    }

    @FXML
    private void btnTwo_Click() {
        System.out.println("Two");
        Stage s = Main.getPrimaryStage();
        if ( opacity > 0.2) {
            opacity -= 0.1;
        }else  {
            opacity = 0.99;
        }
            s.setOpacity(opacity);

    }

    @FXML
    private void btnThree_Click() {
        System.out.println("Three");
        Stage s = Main.getPrimaryStage();
        s.getScene().getStylesheets().remove("css/red.css");
    }
    @FXML
    private void setMuClose(){
        System.out.println("hi");
        Stage s = Main.getPrimaryStage();
        s.close();
    }
}
