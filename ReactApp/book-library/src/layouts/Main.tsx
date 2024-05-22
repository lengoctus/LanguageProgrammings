import { Container } from "reactstrap";
import { Header } from "./Header";
import { Sidebar } from "./Sidebar";
import { Outlet } from "react-router-dom";

interface MainProps {}

export const Main: React.FC<MainProps> = () => {
  return (
    <main>
      {/* <Header /> */}

      <div className="pageWrapper d-lg-flex">
        {/* SideBar Area */}
        <aside className="left-sidebar" id="sidebarArea">
          <Sidebar />
        </aside>

        {/* Content Area   */}
        <div className="contentArea">
          <Container className="p-4" fluid>
            <Outlet />
          </Container>
        </div>
      </div>
    </main>
  );
};
