import { Outlet } from "react-router-dom";
import { Container } from "reactstrap";
import { Header } from "./Header";
import { Sidebar } from "./Sidebar";
import { Header_2 } from "./Header_2";

const FullLayout: React.FC = () => {
  return (
    <main>
      <Header_2 />
      {/* <div className="pageWrapper d-lg-flex">
        <aside className="sidebarArea shadow" id="sidebarArea">
          <Sidebar />
        </aside>
        <div className="contentArea">
          <Container className="p-4" fluid>
            <Outlet />
          </Container>
        </div>
      </div> */}
    </main>
  );
};

export default FullLayout;
