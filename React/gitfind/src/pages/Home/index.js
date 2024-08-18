import { Header } from "../../components/Header";
import background from "../../assets/96efc3f4acbbd24218025f242fae2c4f.png";

import "./styles.css";

function App() {
  return (
    <div className="App">
      <Header />
      <div className="conteudo">
        <img scr={background} className="background" alt="background app" />
        <div className="info">
          <input name="usuario" placeholder="@username" />
          <button>Buscar</button>
        </div>
      </div>
    </div>
  );
}

export default App;
