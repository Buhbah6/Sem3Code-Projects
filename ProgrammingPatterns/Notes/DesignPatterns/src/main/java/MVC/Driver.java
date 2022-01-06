package MVC;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        GameConsole gc = new GameConsole("GameCube", "Smash Melee", "Fuck if I know");
        GameConsoleView view = new GameConsoleView();
        GameConsoleController control = new GameConsoleController(gc, view);
        
        control.updateView();
        control.setName("N64");
        control.updateView();
        control.setReleaseYear("Some time long ago");
        control.setCurrentGame("Smash 64 bitches");
        control.updateView();
    }
    
}
