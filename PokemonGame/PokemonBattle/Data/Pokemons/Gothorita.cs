using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gothorita : Pokemon
{
	public override string Name => "Gothorita";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Frisk(), new Abilities.Competitive() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shadowtag() };
	public override Stats BaseStats => new Stats(60, 45, 70, 75, 85, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Confusion(), new Moves.Playnice(), new Moves.Tickle() },
		[12] = new List<Move>() { new Moves.Psybeam() },
		[16] = new List<Move>() { new Moves.Charm() },
		[20] = new List<Move>() { new Moves.Psyshock() },
		[24] = new List<Move>() { new Moves.Hypnosis() },
		[28] = new List<Move>() { new Moves.Faketears() },
		[35] = new List<Move>() { new Moves.Psychup() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[46] = new List<Move>() { new Moves.Flatter() },
		[52] = new List<Move>() { new Moves.Futuresight() },
		[58] = new List<Move>() { new Moves.Magicroom() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Zenheadbutt() };
	public override int Weight => 180;
	public override int ExpYield => 137;
	public override int CatchRate => 100;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}