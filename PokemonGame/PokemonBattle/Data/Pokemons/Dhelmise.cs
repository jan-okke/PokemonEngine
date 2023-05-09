using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dhelmise : Pokemon
{
	public override string Name => "Dhelmise";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Steelworker() };
	public override Stats BaseStats => new Stats(70, 131, 100, 86, 90, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Rapidspin() },
		[4] = new List<Move>() { new Moves.Astonish() },
		[8] = new List<Move>() { new Moves.Wrap() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Growth() },
		[20] = new List<Move>() { new Moves.Gyroball() },
		[24] = new List<Move>() { new Moves.Switcheroo() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Whirlpool() },
		[36] = new List<Move>() { new Moves.Heavyslam() },
		[40] = new List<Move>() { new Moves.Slam() },
		[44] = new List<Move>() { new Moves.Shadowball() },
		[48] = new List<Move>() { new Moves.Metalsound() },
		[52] = new List<Move>() { new Moves.Anchorshot() },
		[56] = new List<Move>() { new Moves.Energyball() },
		[60] = new List<Move>() { new Moves.Phantomforce() },
		[64] = new List<Move>() { new Moves.Powerwhip() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Bodypress(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Whirlpool() };
	public override int Weight => 2100;
	public override int ExpYield => 181;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}