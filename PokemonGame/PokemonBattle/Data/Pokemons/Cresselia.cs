using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cresselia : Pokemon
{
	public override string Name => "Cresselia";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(120, 70, 120, 75, 130, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Doubleteam() },
		[6] = new List<Move>() { new Moves.Mist() },
		[12] = new List<Move>() { new Moves.Aurorabeam() },
		[18] = new List<Move>() { new Moves.Psybeam() },
		[24] = new List<Move>() { new Moves.Psychoshift() },
		[30] = new List<Move>() { new Moves.Slash() },
		[36] = new List<Move>() { new Moves.Psychocut() },
		[42] = new List<Move>() { new Moves.Moonlight() },
		[48] = new List<Move>() { new Moves.Safeguard() },
		[54] = new List<Move>() { new Moves.Psychic() },
		[60] = new List<Move>() { new Moves.Moonblast() },
		[66] = new List<Move>() { new Moves.Futuresight() },
		[72] = new List<Move>() { new Moves.Lunardance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flash(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Zenheadbutt() };
	public override int Weight => 856;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}