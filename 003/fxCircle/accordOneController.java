package fxCircle;

import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.Parent;
import javafx.scene.control.Accordion;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.paint.Paint;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;
import javafx.scene.input.ScrollEvent;
import javafx.scene.Node;
import javafx.scene.paint.Color;

public class accordOneController {
    private Stage s;
    private Parent p;
    private double opacity;
    private Circle circle;
    @FXML
    private Accordion accordOne;
    @FXML
    private AnchorPane ap;

    private static final double SPEED_BACK = 1.5;
    private static final double SPEED_FORWARD = 3.0;


    public accordOneController() {
        System.out.println("ss");
        opacity = 0.99;
        circle = new Circle(50, 50, 10, Color.BLUE);

    }


    @FXML
    private void accordOneScroll() {
        System.out.println("If you read this you owe me a cookie!");
        p = Main.getRoot();
        s = Main.getStage();
        System.out.println(circle.getLayoutX());
        opacity -= 0.01;
        if (opacity > 0.05) s.setOpacity(opacity);
        else s.setOpacity(opacity = 0.99);
        System.out.println(opacity);
        addMouseScrolling(circle);
        if (!ap.getChildren().contains(circle)) ap.getChildren().add(circle);
        if (opacity < 0.4) circle.setCenterX(100);
        circle.setLayoutX(circle.getLayoutX() + SPEED_FORWARD);
        circle.setStroke(Paint.valueOf("RED"));
        accordOne.setOnKeyPressed(new EventHandler<KeyEvent>() {
            @Override
            public void handle(KeyEvent event) {
                if (event.getCode() == KeyCode.A) {
                    circle.setLayoutX(circle.getLayoutX() - SPEED_BACK);
                }
                if (event.getCode() == KeyCode.D) {
                    circle.setLayoutX(circle.getLayoutX() + SPEED_FORWARD);
                }
                if (event.getCode() == KeyCode.W) {
                    circle.setLayoutY(circle.getLayoutY() - SPEED_BACK);
                }
                if (event.getCode() == KeyCode.S) {
                    circle.setLayoutY(circle.getLayoutY() + SPEED_FORWARD);
                }
                if (event.getCode() == KeyCode.ESCAPE) {
                    s.close();
                }
            }
        });


    }

    public void addMouseScrolling(Node node) {
        node.setOnScroll((ScrollEvent event) -> {
            // Adjust the zoom factor as per your requirement
            double zoomFactor = 1.05;
            double deltaY = event.getDeltaY();
            if (deltaY < 0) {
                zoomFactor = 2.0 - zoomFactor;
            }
            node.setScaleX(node.getScaleX() * zoomFactor);
            node.setScaleY(node.getScaleY() * zoomFactor);
        });
    }

}

