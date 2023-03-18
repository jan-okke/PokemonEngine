using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spoink : Pokemon
	{
		public override string Name => "Spoink";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(60, 25, 35, 70, 80, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Splash() },
			[7] = new List<Move>() { new Moves.Confusion() },
			[10] = new List<Move>() { new Moves.Growl() },
			[14] = new List<Move>() { new Moves.Psybeam() },
			[15] = new List<Move>() { new Moves.Psychup() },
			[18] = new List<Move>() { new Moves.Confuseray() },
			[21] = new List<Move>() { new Moves.Magiccoat() },
			[26] = new List<Move>() { new Moves.Zenheadbutt() },
			[29] = new List<Move>() { new Moves.Powergem(), new Moves.Rest() },
			[33] = new List<Move>() { new Moves.Snore() },
			[38] = new List<Move>() { new Moves.Psyshock() },
			[40] = new List<Move>() { new Moves.Payback() },
			[44] = new List<Move>() { new Moves.Psychic() },
			[50] = new List<Move>() { new Moves.Bounce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bounce(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Extrasensory(), new Moves.Futuresight(), new Moves.Mirrorcoat(), new Moves.Simplebeam(), new Moves.Trick(), new Moves.Whirlwind(), new Moves.Zenheadbutt() };
		public override int Weight => 306;
		public override int ExpYield => 66;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}