package MVC;

/**
 * @author Anthony
 */
public class GameConsoleController {
    private GameConsole gc;
    private GameConsoleView gcView;

    public GameConsoleController(GameConsole gc, GameConsoleView gcView) {
        this.gc = gc;
        this.gcView = gcView;
    }
    
    public String getName() {
        return gc.getName();
    }

    public void setName(String name) {
        gc.setName(name);
    }

    public String getCurrentGame() {
        return gc.getCurrentGame();
    }

    public void setCurrentGame(String currentGame) {
        gc.setCurrentGame(currentGame);
    }

    public String getReleaseYear() {
        return gc.getReleaseYear();
    }

    public void setReleaseYear(String releaseYear) {
        gc.setReleaseYear(releaseYear);
    }
    
    public void updateView() {
        gcView.printGameConsoleDetails(gc);
    }
}
