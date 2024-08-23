import React from "react";
import { useForm } from "react-hook-form";
import { Button, Input } from "../../components";
import { yupResolver } from "@hookform/resolvers/yup";
import { SignUpValidationSchema } from "../../validation/schemas";

import { Container, LoginContainer, Column, Spacing, Title } from "./styles";
import { IFormLogin, defaultValues } from "./types";

const Login = () => {
  const {
    control,
    formState: { errors, isValid },
  } = useForm<IFormLogin>({
    resolver: yupResolver(SignUpValidationSchema),
    mode: "onBlur",
    defaultValues,
    reValidateMode: "onChange",
  });

  return (
    <Container>
      <LoginContainer>
        <Column>
          <Title>Login</Title>
          <Spacing />
          <Input
            name="email"
            placeholder="Email"
            control={control}
            errorMessage={errors?.email?.message}
          />
          <Spacing />
          <Input
            name="password"
            type="password"
            placeholder="Senha"
            control={control}
            errorMessage={errors?.password?.message}
          />
          <Spacing />
          <Button title="Entrar" />
        </Column>
      </LoginContainer>
    </Container>
  );
};

export default Login;
