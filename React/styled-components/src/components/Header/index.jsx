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

const Header = () => {
  return (
    <Wrapper>
      <Container>
        <Row>
          <img src="#" alt="Logo da dio"></img>
          <BuscarInputContainer>
            <Input placeholder="Buscar..." />
          </BuscarInputContainer>
          <Menu>Live Code</Menu>
          <Menu>Global</Menu>
        </Row>
        <Row>
          <MenuRigth href="#">Home</MenuRigth>
          <Button title="Entrar" />
          <Button title="Cadastrar" />
        </Row>
      </Container>
    </Wrapper>
  );
};

export { Header };
