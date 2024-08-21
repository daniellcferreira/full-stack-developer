import { Link } from "react-router-dom";

import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Card } from "../../components/Card";
import { UserInfo } from "../../components/UserInfo";

import { Container, Column, Title, TitleHighLight } from "./styles";

const Feed = () => {
  return (
    <>
      <Header autenticado={true} />
      <Container>
        <Column flex={3}>
          <Title>Feed</Title>
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
        </Column>
        <Column flex={1}>
          <TitleHighLight># RANKING DA SEMANA</TitleHighLight>
          <UserInfo percentual={35} nome="nome" image="" />
          <UserInfo percentual={15} nome="nome" image="" />
          <UserInfo percentual={85} nome="nome" image="" />
          <UserInfo percentual={33} nome="nome" image="" />
          <UserInfo percentual={15} nome="nome" image="" />
        </Column>
      </Container>
    </>
  );
};

export { Feed };
