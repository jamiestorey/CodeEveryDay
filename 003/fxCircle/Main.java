package fxCircle;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class Main extends Application {

    private static  Stage stage;
    private  static Parent root;
    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("sample.fxml"));
        primaryStage.setTitle("Hello World");
        primaryStage.setScene(new Scene(root, 300, 275));
        stage = primaryStage;
        primaryStage.show();
    }

    public static Stage getStage(){
        return stage;
    }

    public static Parent getRoot(){
        return root;
    }

    public static void main(String[] args) {
        launch(args);
    }

}
