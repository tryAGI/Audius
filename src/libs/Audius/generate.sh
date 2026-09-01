#!/usr/bin/env bash
set -euo pipefail

readonly SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
  dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  -o openapi.yaml \
  https://raw.githubusercontent.com/AudiusProject/apps/main/packages/docs/docs/public/openapi.yaml
python3 - <<'PY'
from pathlib import Path

path = Path("openapi.yaml")
text = path.read_text(encoding="utf-8")
old = "operationId: Get User's Track History"
new = "operationId: Get User Track History"
if text.count(old) != 1:
    raise SystemExit(f"Expected exactly one Audius operationId override target, found {text.count(old)}")
text = text.replace(old, new)
required_route_id = "        - route_id\n"
if text.count(required_route_id) != 2:
    raise SystemExit(f"Expected exactly two required route_id entries, found {text.count(required_route_id)}")
text = text.replace(required_route_id, "")
path.write_text(text, encoding="utf-8")
PY
autosdk generate openapi.yaml \
  --namespace Audius \
  --clientClassName AudiusClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-retry-handler \
  --generate-http-exception-hierarchy \
  --generate-pageable-helpers \
  --generate-raw-model-data \
  --direction-aware-json-generation-mode
