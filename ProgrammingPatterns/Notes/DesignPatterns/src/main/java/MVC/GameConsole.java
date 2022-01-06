package MVC;

/**
 * @author Anthony Nadeau
 */
public class GameConsole {
    private String name;
    private String currentGame;
    private String releaseYear;

    public GameConsole(String name, String currentGame, String releaseYear) {
        this.name = name;
        this.currentGame = currentGame;
        this.releaseYear = releaseYear;
    }

    @Override
    public String toString() {
        return "GameConsole{" + "name=" + name + ", currentGame=" + currentGame + ", releaseYear=" + releaseYear + '}';
    }
    
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCurrentGame() {
        return currentGame;
    }

    public void setCurrentGame(String currentGame) {
        this.currentGame = currentGame;
    }

    public String getReleaseYear() {
        return releaseYear;
    }

    public void setReleaseYear(String releaseYear) {
        this.releaseYear = releaseYear;
    }
    
    
}
