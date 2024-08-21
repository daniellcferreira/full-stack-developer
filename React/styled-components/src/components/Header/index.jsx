import React from "react";
import { Button } from "../Button";

import {
  BuscarInputContainer,
  Container,
  Input,
  Menu,
  MenuRigth,
  Row,
  Wrapper,
} from "./styles";

const Header = ({ autenticado }) => {
  return (
    <Wrapper>
      <Container>
        <Row>
          <img src="#" alt="Logo da dio"></img>
          {autenticado ? (
            <>
              <BuscarInputContainer>
                <Input placeholder="Buscar..." />
              </BuscarInputContainer>
              <Menu>Live Code</Menu>
              <Menu>Global</Menu>
            </>
          ) : null}
        </Row>
        <Row>
          {autenticado ? (
            <>
              <MenuRigth href="#">Home</MenuRigth>
              <Button title="Entrar" />
              <Button title="Cadastrar" />
            </>
          ) : null}
        </Row>
      </Container>
    </Wrapper>
  );
};

export { Header };
