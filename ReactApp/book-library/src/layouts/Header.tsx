import { Navbar } from "reactstrap";
import Logo from "./Logo";

interface IHeaderProps {}
export const Header: React.FC<IHeaderProps> = () => {
  return (
    <Navbar expand="md" className="fix-header">
      <div className="d-flex align-items-center">
        <div className="d-lg-block d-none me-5 pe-3">
          <Logo />
        </div>
      </div>
    </Navbar>
  );
};
