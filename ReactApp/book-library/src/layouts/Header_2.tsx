import { FC } from "react";
import { Navbar } from "reactstrap";
import { Logo } from "./Logo";

export const Header_2: FC = () => {
  return (
    <Navbar color="white" light expand="md">
      <div className="d-flex align-items-center">
        <div className="d-lg-block d-none me-5 pe-3">
          <Logo />
        </div>
      </div>
    </Navbar>
  );
};
